using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsApp.DataLayer;
using System.Reflection;

namespace ProductsApp.Models
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

                        if (dr[pi.Name] != DBNull.Value)
                        {
                            pi.SetValue(this, dr[pi.Name], null);
                        }
                           
                    }
                        
                }
            }
        }
    }
}
