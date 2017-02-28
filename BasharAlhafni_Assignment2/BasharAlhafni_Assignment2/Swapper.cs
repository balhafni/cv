using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasharAlhafni_Assignment2
{
    class Swapper
    {
        public void SwapDoubles(ref double  firstNumber, ref double secondNumber)
        {
            double temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }


        public void SwapStrings(ref string firstString, ref string secondString)
        {
            string temp = firstString;
            firstString = secondString;
            secondString = temp;
        }
        
        public void SwapStudents(ref Student s1, ref Student s2)
        {
            Student temp = s1;
            s1 = s2;
            s2 = temp;
        }
    }
}
