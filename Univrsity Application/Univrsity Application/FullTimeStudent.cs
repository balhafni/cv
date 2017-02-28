using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    abstract class FullTimeStudent : Student
    {
        

        public FullTimeStudent(string fname, string lname, string id, string telepone, string streetAdd, string city, double test1, double test2) :
            base(fname, lname, streetAdd, city, telepone,test1, test2)
        {
            this.id = id;
        }
        string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public override string ToString()
        {
            return "First Name: " + FirstName + "\nLast Name: " + LastName + "\nID: " + Id + "\nStreet Address: " + StreetAddress + "\nCity: " + City
                + "\nTelephone: " + String.Format("{0:(###) ###-####}", double.Parse(Telephone)) + "\nTest1: " + Test1 + "\nTest2: " + Test2 + "\nOver all grade: " + ComputeGrade();
        }
    }
}
