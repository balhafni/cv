using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeProcessing
{
    public class Student
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
        Major student_Major;
        public Major Student_Major
        {
            get { return student_Major; }
            set { student_Major = value; }
        }
        Level student_Level;
        public Level Student_Level
        {
            get { return student_Level; }
            set { student_Level = value; }
        }
        public string computeGrade()
        {
            try
            {

                string grade = "";
                double avg;
                if (student_Level == Level.UG)
                {
                    avg = 0.4 * test1 + 0.6 * test2;
                }
                else
                {
                    avg = 0.5 * test1 + 0.5 * test2;
                }
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

            catch (Exception ex)
            {
                throw;
            }

        }
        public override string ToString()
        {
            return id + "," + LastName + "," + student_Major.ToString() + "," + computeGrade();
        }
    }
}
