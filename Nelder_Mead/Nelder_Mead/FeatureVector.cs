using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelder_Mead
{
    class FeatureVector
    {

        double a;
        public double A {
            get { return a; }
            set { a = value; }
        }

        double b;
        public double B
        {
            get { return b; }
            set { a = value; }
        }

        double c;
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        double d;
        public double D
        {
            get { return d; }
            set { d = value; }
        }

        double t1;
        public double T1
        {
            get { return t1; }
            set { t1 = value; }
        }

        double t2;
        public double T2
        {
            get { return t2; }
            set { t2 = value; }
        }
        double mi;
        public double MI
        {
            get { return mi; }
            set { mi = value; }
        }
        public FeatureVector(double a, double b, double c, double d, double t1, double t2)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.T1 = t1;
            this.T2 = t2;
        }
    }
}
