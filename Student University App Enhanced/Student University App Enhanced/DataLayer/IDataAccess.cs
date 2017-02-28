using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Student_University_App_Enhanced.DataLayer
{
    public interface IDataAccess
    {
        object GetSingleAnswer(string sql, List<DbParameter> PList,
       SqlConnection conn = null, SqlTransaction sqtr = null, bool bTransaction = false);
        DataTable GetManyRowsCols(string sql, List<DbParameter> PList,
       SqlConnection conn = null, SqlTransaction sqtr = null, bool bTransaction = false);
        int InsertUpdateDelete(string sql, List<DbParameter> PList,
       SqlConnection conn = null, SqlTransaction sqtr = null, bool bTransaction = false);

        int CheckExistence(string sql, List<DbParameter> PList, SqlConnection conn = null, SqlTransaction sqtr = null, bool bTransaction = false);
    }
}
