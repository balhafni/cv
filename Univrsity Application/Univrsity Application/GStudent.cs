using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    class GStudent : FullTimeStudent
    {
      

        public GStudent(string fname, string lname, string id, string thesis, string telephone, string streetAdd, string city, double test1, double test2) :
            base(fname, lname, id, telephone, streetAdd, city, test1, test2)
        {
            this.thesis = thesis;
        }

        string thesis;
        public string Thesis
        {
            get { return thesis; }
            set { thesis = value; }
        }

        public override string ToString()
        {
            return "First Name: " + FirstName + "\nLast Name: " + LastName + "\nID: " + Id + "\nThesis: " + thesis + "\nStreet Address: " + StreetAddress + "\nCity: " + City
                + "\nTelephone: " + String.Format("{0:(###) ###-####}", double.Parse(Telephone)) + "\nTest1: " + Test1 + "\nTest2: " + Test2 + "\nOver all grade: " + ComputeGrade();
        }
    }
}
