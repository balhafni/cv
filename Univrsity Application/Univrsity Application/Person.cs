using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    abstract class Person
    {
        public Person(string fname, string lname, string streetAdd, string city, string phone)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.streetAddress = streetAdd;
            this.city = city;
            this.telephone = phone;
           
        }
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

        string streetAddress;
        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }
        string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        string telephone;
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public bool CheckTelephone()
        {
            if (Telephone.Length < 10)
            {
                return false;
            }
            return true;
        }
    }
}
