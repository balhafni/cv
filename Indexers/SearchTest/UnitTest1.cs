using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Indexers;
using System.Collections;

namespace SearchTest
{
    [TestClass]
    public class UnitTest1
    {

        OnlineStore store = new OnlineStore();

        [TestMethod]
        public void TestMethod1()
        {

            Product prod = store[1212];
            Assert.AreEqual(prod.ProductName,"MacBook Pro");
        }

        [TestMethod]
        public void TestMethod2()
        {
            
            Product prod = store["Galaxy S6"];
            Assert.AreEqual(prod.Description, "Samsung Smart Phone");
        }

        [TestMethod]
        public void TestMethod3()
        {

            ArrayList prods = store["Smart",SearchType.DESCRIPTION];
            Product prod = (Product)prods[0];
            Product anotherProd = (Product)prods[1];
            Assert.AreEqual("Samsung Smart Phone", prod.Description);
            Assert.AreEqual("Apple Watch", anotherProd.ProductName);
        }

        [TestMethod]
        public void TestMethod4()
        {

            ArrayList prods = store[Category.BOOKS];
            Product prod = (Product)prods[0];
            Product anotherProd = (Product)prods[1];
            Product thirdProd = (Product)prods[2];
            Assert.AreEqual("Cracking the coding Interview", prod.ProductName);
            Assert.AreEqual("Essential Calculus", anotherProd.ProductName);
            Assert.AreEqual(1616, thirdProd.ProductId);
        }


    }
}
