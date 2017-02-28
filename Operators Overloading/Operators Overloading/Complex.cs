using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Overloading
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex res = new Complex();
            res.Real = c1.Real + c2.Real;
            res.Imaginary = c1.Imaginary + c2.Imaginary;
            return res;
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex res = new Complex();
            res.Real = c1.Real - c2.Real;
            res.Imaginary = c1.Imaginary - c2.Imaginary;
            return res;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex res = new Complex();
            res.Real = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            res.Imaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return res;
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex res = new Complex();
            int denominator = 0;

            denominator = (int)(Math.Pow(c2.Real, 2) + Math.Pow(c2.Imaginary, 2));
            c2.Imaginary = -1 * c2.Imaginary;

            res.Real = (c1.Real * c2.Real - c1.Imaginary * c2.Imaginary) / denominator;
            res.Imaginary = (c1.Real * c2.Imaginary + c1.Imaginary * c2.Real) / denominator;
            return res;
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return c1.Real != c2.Real || c1.Imaginary != c2.Imaginary;
        }

        public static bool operator <(Complex c1, Complex c2)
        {
            if (c1.Real < c2.Real)
            {
                return true;
            }
            else if (c1.Real == c2.Real)
            {
                if (c1.Imaginary < c2.Imaginary)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static bool operator >(Complex c1, Complex c2)
        {
            if (c1.Real > c2.Real)
            {
                return true;
            }
            else if (c1.Real == c2.Real)
            {
                if (c1.Imaginary > c2.Imaginary)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static Complex operator ++(Complex c)
        {
            c.Real++;
            return c;
        }
        public static Complex operator --(Complex c)
        {
            c.Real--;
            return c;
        }
    }
}

