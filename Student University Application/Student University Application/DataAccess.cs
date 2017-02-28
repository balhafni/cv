using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Student_University_Application
{
    class DataAccess
    {
        static string connStr = "server = BASHAR\\SQLEXPRESS;integrated security = true;database = UBDB";
        public static object GetSingleAnswer(string sql)
        {
            object obj = null;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                obj = cmd.ExecuteScalar();
            }catch(Exception ex)
            {
                throw;
            }
            finally{
                conn.Close();
            }
            return obj;
        }

        public static int InsertUpdateDelete(string sql)
        {
            int rows = 0;
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                rows = cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return rows;
        }

        public static DataTable GetManyRowsCols(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }catch(Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static int CheckExistence(string sql)
        {
          
                int rows = 0;
                SqlConnection conn = new SqlConnection(connStr);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    rows = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                return rows;
            }
        }
    }
