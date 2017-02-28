using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace ProductsApp
{
    public interface IDataAccess
    {
        // transaction capable methods, last three parametes of Sqlonnection,SqlTransaction are optional
        object GetSingleAnswer(string sql, List<DbParameter> PList, SqlConnection
       conn = null, SqlTransaction sqtr = null, bool bTransaction = false);
        DataTable GetManyRowsCols(string sql, List<DbParameter> PList, SqlConnection
       conn = null, SqlTransaction sqtr = null, bool bTransaction = false);
        int InsertUpdateDelete(string sql, List<DbParameter> PList, SqlConnection
       conn = null, SqlTransaction sqtr = null, bool bTransaction = false);
    }
}
