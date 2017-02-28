using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_University_App_Enhanced.DataLayer;
using System.Reflection;

namespace Student_University_App_Enhanced.Models
{
    public class EntityBase : IEntity
    {
        public void SetFields(DataRow dr)
        {
            // use reflection to set the fields from DataRow
            Type tp = this.GetType();

            foreach (PropertyInfo pi in tp.GetProperties())
            {
                if (null != pi && pi.CanWrite)
                {

                    string nm = pi.PropertyType.Name.ToUpper();
                    if (nm.IndexOf("ENTITY") >= 0) // In LINQ to SQL Classes, last properties are links to other tables
                        break;
                    if (pi.PropertyType.Name.ToUpper() != "BINARY")
                    {
                        if (dr.Table.Columns.Contains(pi.Name))//checking if the column exist in the datarow or not
                        {
                            if (dr[pi.Name] != DBNull.Value)
                                pi.SetValue(this, dr[pi.Name], null);
                        }

                    }

                }
            }
        }
        public void SetObjectFields(string[] str)
        {

            int i = 0;
            Type tp = this.GetType();
            foreach (PropertyInfo pi in tp.GetProperties())
            {
                if (pi != null && pi.CanWrite)
                {
                    string nm = pi.PropertyType.Name.ToUpper();
                    if (nm.IndexOf("ENTITY") >= 0)
                        break;
                    if (pi.PropertyType.Name.ToUpper() != "BINARY")
                    {
                        //checking for nullable types!
                        if (pi.PropertyType.IsGenericType && pi.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            pi.SetValue(this, Convert.ChangeType(str[i], pi.PropertyType.GetGenericArguments()[0]), null);
                        }
                        else {
                            pi.SetValue(this, Convert.ChangeType(str[i], pi.PropertyType), null);
                        }
                        i++;

                    }
                }
            }
        }
    }
}
