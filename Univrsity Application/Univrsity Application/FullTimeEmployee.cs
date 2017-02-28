using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    abstract class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string fname, string lname, string id, string dpt, string streetAdd, string city, string telephone) :
            base(fname, lname, dpt, streetAdd, city, telephone)
        {
            this.id = id;
        }
        string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public override string ToString()
        {
            return "First Name: " + FirstName + "\nLast Name: " + LastName + "\nID: " + id + "\nStreet Address: " + StreetAddress + "\nCity: " + City +
                "\nTelephone: " + String.Format("{0:(###) ###-####}", double.Parse(Telephone));
        }
    }
}
