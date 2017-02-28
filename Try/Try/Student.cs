using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    public class Student<T1,T2>
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
      
        public string computeGrade()
        {
            try
            {

                string grade = "";
                double avg;
               
            
                    avg = 0.4 * test1 + 0.6 * test2;
               
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
        T1 a;
        public T1 A
        {
            get { return a; }
            set { a = value; }
        }
        T2 b;
        public T2 B
        {
            get { return b; }
            set { b = value; }
        }
        public override string ToString()
        {
            return id + "," + LastName + "," + "," + computeGrade();
        }
    }

    delegate string DelCompute();
}
