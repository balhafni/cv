using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    class PartTimeFaculty : Employee
    {
        public PartTimeFaculty(string fname, string lname, string ssn, string dpt, string streetAdd, string city, string telephone) :
            base(fname, lname, dpt, streetAdd, city, telephone)
        {
            this.ssn = ssn;
        }
        string ssn;
        public string SSn
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public override string ToString()
        {
            return "First Name: " + FirstName + "\nLast Name: " + LastName + "\nSSN: " + ssn + "\nStreet Address: " + StreetAddress + "\nCity: " + City +
                "\nTelephone: " + String.Format("{0:(###) ###-####}", Telephone);
        }
    }
}

