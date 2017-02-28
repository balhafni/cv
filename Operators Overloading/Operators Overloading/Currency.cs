using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Overloading
{
    public class Currency
    {
        int dollars;
        public int Dollars { get; set; }
        double cents;
        public double Cents { get; set; }



        public override string ToString()
        {
            return "$" + Dollars + "." + Cents;
        }

        public static Currency operator +(Currency c1, Currency c2)
        {
            Currency res = new Currency();
            res.Dollars = c1.Dollars + c2.Dollars;
            res.Cents = c1.Cents + c2.Cents;
            if (res.Cents >= 100)
            {
                res.Cents -= 100;
                res.Dollars++;
            }
            return res;
        }

        public static Currency operator -(Currency c1, Currency c2)
        {
            Currency res = new Currency();
            double convertedC1 = convertingToCents(c1.Dollars) + c1.Cents;
            double convertedC2 = convertingToCents(c2.Dollars) + c2.Cents;
            double result = (convertedC1 - convertedC2) / 100;
            res.Dollars = (int)result;
            string value = result.ToString();
            string centsValue = value.Substring(value.IndexOf('.'));
            res.Cents = Double.Parse(centsValue) * 100;

            return res;
        }

        public static bool operator ==(Currency c1, Currency c2)
        {
            return c1.Dollars == c2.Dollars && c1.Cents == c2.Cents;
        }
        public static bool operator !=(Currency c1, Currency c2)
        {
            return c1.Dollars != c2.Dollars || c1.Cents != c2.Cents;
        }

        public static bool operator >(Currency c1, Currency c2)
        {
            if (c1.Dollars > c2.Dollars)
                return true;
            else if (c1.Dollars == c2.Dollars)
            {
                if (c1.Cents > c2.Cents)
                    return true;
            }
            return false;
        }

        public static bool operator <(Currency c1, Currency c2)
        {
            if (c1.Dollars < c2.Dollars)
                return true;
            else if (c1.Dollars == c2.Dollars)
            {
                if (c1.Cents < c2.Cents)
                {
                    return true;
                }
            }
            return false;
        }

        public static Currency operator --(Currency c)
        {
            c.Dollars--;
            return c;
        }
        public static Currency operator ++(Currency c)
        {
            c.Dollars++;
            return c;
        }

        public static int convertingToCents(int dollars)
        {
            return dollars * 100;
        }

    }

}
