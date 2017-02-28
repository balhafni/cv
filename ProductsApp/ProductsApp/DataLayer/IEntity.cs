using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ProductsApp.DataLayer
{
   public  interface IEntity
    {
        void SetFields(DataRow dr);
    }
}
