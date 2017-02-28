using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    abstract class Student:Person
    {
     

        public Student(string fname, string lname, string streetAdd, string city, string phone, double test1, double test2) :
            base(fname, lname, streetAdd, city, phone)
        {

            this.test1 = test1;
            this.test2 = test2;
        }


        double test1;
        public double Test1
        {
            get { return test1; }
            set { test1 = value; }
        }
        double test2;
        public double Test2
        {
            get { return test2; }
            set { test2 = value; }
        }
        public bool CheckGrade()
        {
            if (test1 > 100 || test1 < 0 || test2 > 100 || test2 < 0)
            {
                return false;
            }
            return true;
        }
       
        public virtual string ComputeGrade()
        {
            double average = 0.45 * Test1 + 0.55 * Test2;
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
    }
}
