using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    class UGStudent : FullTimeStudent
    {
        public UGStudent(string fname,string lname, string id, string telephone, string streetAdd, string city, double test1,double test2):base(fname,lname,id,
            telephone, streetAdd, city, test1, test2)
        {

        }
        
        

    }
}
