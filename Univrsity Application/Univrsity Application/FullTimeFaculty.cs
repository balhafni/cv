using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univrsity_Application
{
    class FullTimeFaculty:FullTimeEmployee
    {

        public FullTimeFaculty(string fname,string lname,string id, string dpt,string rank, string streetAdd, string city, string telephone):
            base(fname, lname, id, dpt, streetAdd, city, telephone)
        {
            this.rank = rank;
        }
        string rank;
        public string Rank {
            get { return rank; }
            set { rank = value; }
        }

        public override string ToString()
        {
            return "First Name: " + FirstName + "\nLast Name: " + LastName + "\nEmployee ID: " + ID + "\nRank: " + rank + "\nStreet Address: " + StreetAddress
                + "\nCity: " + City + "\nTelephone: " + String.Format("{0:(###) ###-####}", double.Parse(Telephone));
        }
    }
}
