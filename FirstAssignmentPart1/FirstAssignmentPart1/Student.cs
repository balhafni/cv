using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignmentPart1
{
    class Student
    {
        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        int test1;
        public int Test1
        {
            get { return test1; }
            set { test1 = value; }
        }

        int test2;
        public int Test2
        {
            get { return test2; }
            set { test2 = value; }
        }
        public string ComputeGrade()
        {
            string grade = "";
            double avg = 0.6 * test1 + 0.4 * test2;
            if (avg > 90)
            {
                grade = "A";
            }
            else if (avg > 85)
            {
                grade = "B";
            }
            else if (avg > 75)
            {
                grade = "C";
            }
            else if (avg > 65)
            {
                grade = "D";
            }
            else
            {
                grade = "F";

            }
            return grade;
        }
    }
}
