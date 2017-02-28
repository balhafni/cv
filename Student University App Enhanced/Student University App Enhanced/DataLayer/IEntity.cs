using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Student_University_App_Enhanced.DataLayer
{
    public interface IEntity
    {
        void SetFields(DataRow dr);
        void SetObjectFields(string[] str);
    }
}
