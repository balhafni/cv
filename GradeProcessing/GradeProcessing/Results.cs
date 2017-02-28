using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeProcessing
{
    class Results
    {
        int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

       

        Major major;
        public Major Major
        {
            get
            {
                return major;
            }

            set
            {
                major = value;
            }
        }
        string grade;
        public string Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        

        
    }
}
