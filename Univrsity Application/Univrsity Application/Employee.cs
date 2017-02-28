using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    abstract class Employee : Person
    {
        public Employee(string fname, string lname, string dpt, string streetAdd, string city, string phone) :
            base(fname, lname, streetAdd, city, phone)
        {
            department = dpt;

        }
        string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
    }
}

