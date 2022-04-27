using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            //Computer(string year, string color, string os)
            Computer test_computer = new Computer("2020", "Red", "Mac OS", 2.0, 8);
            Assert.AreEqual(2.0, test_computer.Version, .001);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Laptop(screenSz,year,color,os,version)
            Laptop testBook = new Laptop(13.5, "2019", "silver", "Mac OS", 3.0, 8);
            Assert.AreEqual(3.0, testBook.Version, .001);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //SmartPhone(weightInGrams, year, color, os, version)
            SmartPhone testgalaxy10 = new SmartPhone("157g", "2022", "pink", "Droid", 6.0, 8);
            Assert.AreEqual(6.0, testgalaxy10.Version, .001);
        }
    }
}