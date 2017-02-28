using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operators_Overloading;

namespace CurrencyTest
{
    [TestClass]
    public class CurrencyTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Currency c1 = new Currency { Dollars = 1, Cents = 50 };
            Currency c2 = new Currency { Dollars = 0, Cents = 30 };
            Currency res = c1 + c2;
            Assert.AreEqual(1, res.Dollars);
            Assert.AreEqual(80, res.Cents);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Currency c1 = new Currency { Dollars = 2, Cents = 90 };
            Currency c2 = new Currency { Dollars = 0, Cents = 30 };
            Currency res = c1 + c2;
            Assert.AreEqual(3, res.Dollars);
            Assert.AreEqual(20, res.Cents);

        }
        [TestMethod]
        public void TestMethod3()
        {
            Currency c1 = new Currency { Dollars = 1, Cents = 50 };
            Currency c2 = new Currency { Dollars = 0, Cents = 30 };
            Currency res = c1 - c2;
            Assert.AreEqual(1, res.Dollars);
            Assert.AreEqual(20, res.Cents);

        }

        [TestMethod]
        public void TestMethod4()
        {
            Currency c1 = new Currency { Dollars = 3, Cents = 50 };
            Currency c2 = new Currency { Dollars = 5, Cents = 30 };
            Currency res = c1 - c2;
            Assert.AreEqual(-1, res.Dollars);
            Assert.AreEqual(80, res.Cents);

        }

        [TestMethod]
        public void TestMethod5()
        {
            Currency c1 = new Currency { Dollars = 4, Cents = 20 };
            Currency c2 = new Currency { Dollars = 3, Cents = 50 };
            Currency res = c1 - c2;
            Assert.AreEqual(0, res.Dollars);
            Assert.AreEqual(70, res.Cents);

        }
        [TestMethod]
        public void TestMethod6()
        {
            Currency c1 = new Currency { Dollars = 2, Cents = 20 };
            Currency c2 = new Currency { Dollars = 4, Cents = 50 };
            Currency res = c1 - c2;
            Assert.AreEqual(-2, res.Dollars);
            Assert.AreEqual(30, res.Cents);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Currency c1 = new Currency { Dollars = 2, Cents = 1 };
            Currency c2 = new Currency { Dollars = 4, Cents = 50 };
            Currency res = c1 - c2;
            Assert.AreEqual(-2, res.Dollars);
            Assert.AreEqual(49, res.Cents);
        }
        [TestMethod]
        public void TestMethod8()
        {
            Currency c1 = new Currency { Dollars = 100, Cents = 1 };
            Currency c2 = new Currency { Dollars = 4, Cents = 50 };
            Currency res = c1 - c2;
            Assert.AreEqual(95, res.Dollars);
            Assert.AreEqual(51, res.Cents);
        }
        [TestMethod]
        public void TestMethod9()
        {
            Currency c1 = new Currency { Dollars = 2, Cents = 1 };
            Currency c2 = new Currency { Dollars = 4, Cents = 50 };
            Assert.AreEqual(false, c1 == c2);

        }
        [TestMethod]
        public void TestMethod10()
        {
            Currency c1 = new Currency { Dollars = 2, Cents = 50 };
            Currency c2 = new Currency { Dollars = 2, Cents = 50 };
            Assert.AreEqual(true, c1 == c2);

        }
        [TestMethod]
        public void TestMethod11()
        {
            Currency c1 = new Currency { Dollars = 2, Cents = 50 };
            Currency c2 = new Currency { Dollars = 2, Cents = 50 };
            Assert.AreEqual(false, c1 != c2);

        }
        [TestMethod]
        public void TestMethod12()
        {
            Currency c1 = new Currency { Dollars = 2, Cents = 50 };
            Currency c2 = new Currency { Dollars = 100, Cents = 50 };
            Assert.AreEqual(true, c1 != c2);

        }

        [TestMethod]
        public void TestMethod14()
        {
            Currency c1 = new Currency { Dollars = 2, Cents = 50 };
            Currency c2 = new Currency { Dollars = 100, Cents = 50 };
            Assert.AreEqual(true, c1 < c2);

        }

        [TestMethod]
        public void TestMethod15()
        {
            Currency c1 = new Currency { Dollars = 2, Cents = 50 };
            Currency c2 = new Currency { Dollars = 100, Cents = 50 };
            Assert.AreEqual(false, c1 > c2);

        }
        [TestMethod]
        public void TestMethod16()
        {
            Currency c1 = new Currency { Dollars = 2, Cents = 50 };
            c1--;
            Assert.AreEqual(1,c1.Dollars);

        }
        [TestMethod]
        public void TestMethod17()
        {
            Currency c1 = new Currency { Dollars = 2, Cents = 50 };
            c1++;
            Assert.AreEqual(3, c1.Dollars);

        }

    }
}