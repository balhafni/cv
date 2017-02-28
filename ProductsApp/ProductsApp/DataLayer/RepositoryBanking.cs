using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections.Specialized;

namespace ProductsApp.DataLayer
{
    class RepositoryBanking : IRepositoryBanking
    {
        IDataAccess _idac = null;
        public RepositoryBanking()
        {
            string CONNSTR = ConfigurationManager.ConnectionStrings["ProductsApp.Properties.Settings.MorningBankConnectionString"].ConnectionString;
            //string CONNSTR = "server=BASHAR\\SQLEXPRESS;Integrated Security = True; Database = MorningBank";
            _idac = new DataAccess(CONNSTR);
        }
        public RepositoryBanking(IDataAccess idac) { _idac = idac; }

        public decimal GetCheckingBalance(long checkingAcctNum)
        {
            decimal balance = 0;
            try
            {
                string sql = "select balance from CheckingAccounts where CheckingAccountNumber = @CheckingAccountNumber";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@CheckingAccountNumber",
               SqlDbType.BigInt);
                p1.Value = checkingAcctNum;
                ParamList.Add(p1);
                object obj = _idac.GetSingleAnswer(sql, ParamList);
                if (obj != null)
                    balance = decimal.Parse(obj.ToString());
            }
            catch (Exception)
            {
                throw;
            }
            return balance;
        }


        public decimal GetSavingBalance(long savingAcctNum)
        {
            decimal balance = 0;
            try
            {
                string sql = "select balance from SavingAccounts where SavingAccountNumber = @SavingAccountNumber";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@SavingAccountNumber",
               SqlDbType.BigInt);
                p1.Value = savingAcctNum;
                ParamList.Add(p1);
                object obj = _idac.GetSingleAnswer(sql, ParamList);
                if (obj != null)
                    balance = decimal.Parse(obj.ToString());
            }
            catch (Exception)
            {
                throw;
            }
            return balance;
        }

        public bool TransferCheckingToSaving(decimal amount, long checkingAccountNum,
long savingAccountNum)
        {
            // transfer checking to saving has to be done as a transaction
            // transactions are assocated with a connection
            bool ret = false;
            string CONNSTR = ConfigurationManager.ConnectionStrings["ProductsApp.Properties.Settings.MorningBankConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(CONNSTR);
            SqlTransaction sqtr = null;

            try
            {
                conn.Open();
                sqtr = conn.BeginTransaction();
                string sql1 = "Update CheckingAccounts set Balance=Balance-@Amount where CheckingAccountNumber = @CheckingAccountNumber";
                List<DbParameter> ParamList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@CheckingAccountNumber", SqlDbType.BigInt);
                p1.Value = checkingAccountNum;
                ParamList.Add(p1);
                SqlParameter p2 = new SqlParameter("@Amount", SqlDbType.Decimal);
                p2.Value = amount;
                ParamList.Add(p2);
                int rows = _idac.InsertUpdateDelete(sql1, ParamList, conn, sqtr, true);
                // part of transaction
                if (rows > 0)
                {
                    string sql2 = "select Balance from CheckingAccounts where CheckingAccountNumber = @CheckingAccountNumber";
                    List<DbParameter> ParamList2 = new List<DbParameter>();
                    SqlParameter pa = new SqlParameter("@CheckingAccountNumber", SqlDbType.BigInt);
                    pa.Value = checkingAccountNum;
                    ParamList2.Add(pa);
                    object obj = _idac.GetSingleAnswer(sql2, ParamList2, conn, sqtr,true);
                    if (obj != null)
                    {
                        if (decimal.Parse(obj.ToString()) < 0) // exception causes transaction to be rolled back
                            throw new Exception("Insufficient funds in Checking Account - rolling back transaction");
                    }
                }
                else
                    throw new Exception("Problem in transferring from Checking Account..");

                string sql3 = "Update SavingAccounts set Balance=Balance+@Amount where SavingAccountNumber = @SavingAccountNumber";

                List<DbParameter> ParamList3 = new List<DbParameter>();
                SqlParameter pb = new SqlParameter("@SavingAccountNumber",SqlDbType.BigInt);
                pb.Value = savingAccountNum;
                ParamList3.Add(pb);
                SqlParameter pc = new SqlParameter("@Amount", SqlDbType.Decimal);
                pc.Value = amount;
                ParamList3.Add(pc);
                rows = _idac.InsertUpdateDelete(sql3, ParamList3, conn, sqtr, true); //part of transaction
                if (rows > 0)
                {
                    sqtr.Commit();
                    ret = true;
                }
                else
                    throw new Exception("Problem in transferring to Saving Account..");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return ret;
        }
    }
}



