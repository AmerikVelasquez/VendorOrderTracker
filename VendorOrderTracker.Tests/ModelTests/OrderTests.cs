using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("title", "description", 50, 22);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesObjectWithTitle_String()
    {
      string title = "title";
      Order testOrder = new Order(title, "an order", 30 ,16);
      string result = testOrder.Title;
      Assert.AreEqual(title, result);
    }
  }
}