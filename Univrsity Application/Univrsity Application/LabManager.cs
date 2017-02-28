using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    class LabManager : FullTimeEmployee
    {
        public LabManager(string fname, string lname, string id, string dpt, string streetAdd, string city, string telephone) :
            base(fname, lname, id, dpt, streetAdd, city, telephone)
        {
            

        }
    }
}
