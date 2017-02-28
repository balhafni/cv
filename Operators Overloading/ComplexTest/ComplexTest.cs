using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operators_Overloading;
namespace ComplexTest
{
    [TestClass]
    public class ComplexTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Complex c1 = new Complex { Real = 20, Imaginary = 15 };
            Complex c2 = new Complex { Real = 10, Imaginary = 5 };
            Complex res = c1 + c2;
            Assert.AreEqual(30, res.Real);
            Assert.AreEqual(20, res.Imaginary);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Complex c1 = new Complex { Real = -20, Imaginary = 5 };
            Complex c2 = new Complex { Real = 10, Imaginary = 5 };
            Complex res = c1 + c2;
            Assert.AreEqual(-10, res.Real);
            Assert.AreEqual(10, res.Imaginary);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Complex c1 = new Complex { Real = 20, Imaginary = 15 };
            Complex c2 = new Complex { Real = 10, Imaginary = 5 };
            Complex res = c1 - c2;
            Assert.AreEqual(10, res.Real);
            Assert.AreEqual(10, res.Imaginary);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Complex c1 = new Complex { Real = 5, Imaginary = 5 };
            Complex c2 = new Complex { Real = 10, Imaginary = 5 };
            Complex res = c1 - c2;
            Assert.AreEqual(-5, res.Real);
            Assert.AreEqual(0, res.Imaginary);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Complex c1 = new Complex { Real = 4, Imaginary = -3 };
            Complex c2 = new Complex { Real = 2, Imaginary = 5 };
            Complex res = c1 * c2;
            Assert.AreEqual(23, res.Real);
            Assert.AreEqual(14, res.Imaginary);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Complex c1 = new Complex { Real = 10, Imaginary = 5 };
            Complex c2 = new Complex { Real = 5, Imaginary = 5 };
            Complex res = c1 * c2;
            Assert.AreEqual(25, res.Real);
            Assert.AreEqual(75, res.Imaginary);
        }
        [TestMethod]
        public void TestMethod8()
        {
            Complex c1 = new Complex { Real = 3, Imaginary = 2 };
            Complex c2 = new Complex { Real = 4, Imaginary = -3 };
            Complex res = c1 / c2;
            Assert.AreEqual(0.24, res.Real);
            Assert.AreEqual(0.68, res.Imaginary);
        }

        [TestMethod]
        public void TestMethod9()
        {
            Complex c1 = new Complex { Real = 4, Imaginary = 5 };
            Complex c2 = new Complex { Real = 2, Imaginary = 6 };
            Complex res = c1 / c2;
            Assert.AreEqual(0.95, res.Real);
            Assert.AreEqual(-0.35, res.Imaginary);
        }
        [TestMethod]
        public void TestMethod10()
        {
            Complex c1 = new Complex { Real = 4, Imaginary = 5 };
            Complex c2 = new Complex { Real = 2, Imaginary = 6 };
            Assert.AreEqual(true, c1 > c2);
            
        }
        [TestMethod]
        public void TestMethod11()
        {
            Complex c1 = new Complex { Real = 4, Imaginary = 5 };
            Complex c2 = new Complex { Real = 4, Imaginary = 6 };
            Assert.AreEqual(true, c1 < c2);

        }
        [TestMethod]
        public void TestMethod12()
        {
            Complex c1 = new Complex { Real = 4, Imaginary = 5 };
            c1++;
            Assert.AreEqual(5, c1.Real);

        }
        [TestMethod]
        public void TestMethod13()
        {
            Complex c1 = new Complex { Real = 4, Imaginary = 5 };
            c1--;
            Assert.AreEqual(3, c1.Real);

        }
    }
}
