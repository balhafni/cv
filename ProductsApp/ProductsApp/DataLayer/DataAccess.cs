using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;


namespace ProductsApp.DataLayer
{
    public class DataAccess : IDataAccess
    {
        public string CONNSTR =
       ConfigurationManager.ConnectionStrings["ProductsApp.Properties.Settings.NORTHWNDConnectionString"].ConnectionString;
        public DataAccess() { }
        public DataAccess(string connstr) // to be able to change the connectionstring
        {
            this.CONNSTR = connstr;
        }
        #region IDataAccess Members
        public object GetSingleAnswer(string sql, List<DbParameter> PList,
       SqlConnection conn = null, SqlTransaction sqtr = null, bool bTransaction = false)
        {
            object obj = null;
            if (bTransaction == false)
                conn = new SqlConnection(CONNSTR);
            try
            {
                if (bTransaction == false)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (bTransaction == true)
                    cmd.Transaction = sqtr;
                if (PList != null)
                {
                    foreach (DbParameter p in PList)
                        cmd.Parameters.Add(p);
                }
                obj = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (bTransaction == false)
                    conn.Close();
            }
            return obj;
        }

        public DataTable GetManyRowsCols(string sql, List<DbParameter> PList,
SqlConnection conn = null, SqlTransaction sqtr = null, bool bTransaction = false)
        {
            DataTable dt = new DataTable();
            if (bTransaction == false)
                conn = new SqlConnection(CONNSTR);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (PList != null)
                {
                    foreach (DbParameter p in PList)
                        cmd.Parameters.Add(p);
                }
                if (bTransaction == true)
                    cmd.Transaction = sqtr;
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (bTransaction == false)
                    conn.Close();
            }
            return dt;
        }

        public int InsertUpdateDelete(string sql, List<DbParameter> PList,
SqlConnection conn = null, SqlTransaction sqtr = null, bool bTransaction = false)
        {
            int rows = 0;
            if (bTransaction == false)
                conn = new SqlConnection(CONNSTR);
            try
            {
                if (bTransaction == false)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (bTransaction == true)
                    cmd.Transaction = sqtr;
                if (PList != null)
                {
                    foreach (SqlParameter p in PList)
                        cmd.Parameters.Add(p);
                }
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (bTransaction == false)
                    conn.Close();
            }
            return rows;
        }
    }
    #endregion
}
