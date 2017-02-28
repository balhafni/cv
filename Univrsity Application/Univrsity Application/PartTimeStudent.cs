using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    class PartTimeStudent : Student
    {

        public PartTimeStudent(string fname, string lname, string ssn, string telephone, string streetAdd, string city, double test1, double test2) :
            base(fname, lname, streetAdd, city, telephone, test1, test2)
        {
            this.ssn = ssn;
        }
        string ssn;
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public override string ComputeGrade()
        {
            double average = 0.4 * Test1 + 0.6 * Test2;
            if (average > 90)
            {
                return "A";
            }
            else if (average > 85)
            {
                return "A-";
            }
            else if (average > 80)
            {
                return "B";
            }
            else if (average > 75)
            {
                return "B-";
            }
            else if (average > 70)
            {
                return "C";
            }
            else if (average > 65)
            {
                return "C-";
            }
            else
            {
                return "F";
            }
        }
        public override string ToString()
        {
            return "First Name: " + FirstName + "\nLast Name: " + LastName + "\nSSN: " + ssn + "\nStreet Address: " + StreetAddress + "\nCity: " + City +
                "\nTelephone: " + String.Format("{0:(###) ###-####}", double.Parse(Telephone)) + "\nTest1: " + Test1 + "\nTest2: " + Test2;

        }
    }
}
