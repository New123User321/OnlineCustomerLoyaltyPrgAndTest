﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineCustomerLoyaltyPrgAndTestNS;

namespace VendorTestSimplePoint
{

    [TestClass]
    public class givPoint
    {
        
        ProductVendor Hat_ProdVendor;
        Customer customer;

        [TestInitialize]
        public void Setup()
        {
            Hat_ProdVendor = new ProductVendor(1000);
            customer = new Customer();
        }

        [TestMethod]
        public void requireZoroItems()
        {
            int points = Hat_ProdVendor.requirePoints(customer, 0, 0);
            Assert.AreEqual(0, points);
        }

        [TestMethod]
        public void requirePointsOneItem()
        {
            // an item
            int points = Hat_ProdVendor.requirePoints(customer, 1, 1);
            Assert.AreEqual(5, points);

            // another item
            points = Hat_ProdVendor.requirePoints(customer, 2, 1);
            Assert.AreEqual(10, points);
        }

        [TestMethod]
        public void requirePointsTwoItems()
        {
            // two of an item
            int points = Hat_ProdVendor.requirePoints(customer, 1, 1);
            Assert.AreEqual(5, points);

            // two of another item
            points = Hat_ProdVendor.requirePoints(customer, 2, 1);
            Assert.AreEqual(10, points);
        }
    }
}
