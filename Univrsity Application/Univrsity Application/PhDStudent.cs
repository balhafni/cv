using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    class PhDStudent : FullTimeStudent
    {

        public PhDStudent(string fname, string lname, string id, string phdAdvisor, string telephone, string streetAdd, string city, double test1, double test2) :
            base(fname, lname, id, telephone, streetAdd, city, test1, test2)
        {
            this.phdAdvisor = phdAdvisor;
        }

        string phdAdvisor;
        public string PhdAdvisor
        {
            get { return phdAdvisor; }
            set { phdAdvisor = value; }
        }

        public override string ComputeGrade()
        {
            double average = 0.3 * Test1 + 0.7 * Test2;
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
            return "First Name: " + FirstName + "\nLast Name: " + LastName + "\nID: " + Id + "\nPhD Advisor: " + phdAdvisor + "\nStreet Address: " + StreetAddress + "\nCity: " + City
                + "\nTelephone: " + String.Format("{0:(###) ###-####}", Telephone) + "\nTest1: " + Test1 + "\nTest2: " + Test2 + "\nOver all grade: " + ComputeGrade();
        }
    }

}
