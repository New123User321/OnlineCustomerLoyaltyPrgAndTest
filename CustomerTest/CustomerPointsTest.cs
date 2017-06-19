using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineCustomerLoyaltyPrgAndTestNS;

namespace CustomerTest
{
    // TODO ELEV Udskift navnet på UnitTest1 til et mere passende
    // TODO ELEV Omdøb også denne fil til <klassens navn>.cs og commit til git
    [TestClass]
    public class CustomerPointsTest
    {
        ProductVendor theVendor;
        Customer theCustomer;

        [TestInitialize]
        public void Setup()
        {
            theVendor = new ProductVendor(1000);
            theCustomer = new Customer();
        }
        // TODO ELEV Udskift navnet på TestMethod1 til et mere passende
        [TestMethod]
        public void buyZeroItems()
        {
            int points = theVendor.requirePoints(theCustomer, 0, 0);
            Assert.AreEqual(0, points);
        }
        [TestMethod]
        public void buyOneItems()
        {
            int points = theVendor.requirePoints(theCustomer, 1, 1);
            Assert.AreEqual(5, points);
        }
        [TestMethod]
        public void buyTwoOfTheSameItems()
        {
            int points = theVendor.requirePoints(theCustomer, 1, 2);
            Assert.AreEqual(10, points);
        }
        [TestMethod]
        public void buyTwoDiffrentItems()
        {
            int points = theVendor.requirePoints(theCustomer, 1, 1);
            points += theVendor.requirePoints(theCustomer, 2, 1);
            Assert.AreEqual(16, points);
        }


        // TODO ELEV Opret en test der kontrolerer antal point ved køb af 0 varer
        // TODO ELEV    og commit til git
        // TODO ELEV Opret en test der kontrolerer antal point ved køb af 1 vare
        // TODO ELEV    og commit til git
        // TODO ELEV Opret en test der kontrolerer antal point ved køb af 2 ens varer fra samme leverandør (vendor)
        // TODO ELEV    og commit til git
        // TODO ELEV Opret en test der kontrolerer antal point ved køb af 2 forskellige varer fra samme leverandør (vendor)
        // TODO ELEV    og commit til git

    }
}
