using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests :IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void OrderConstructor_CreatesObjectWithDescription_String()
    {
      string description = "an order";
      Order testOrder = new Order("title", description, 30 ,16);
      string result = testOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void OrderConstructor_CreatesObjectWithPrice_Int()
    {
      int price = 30;
      Order testOrder = new Order("title", "an order", price ,16);
      int result = testOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void OrderConstructor_CreatesObjectWithDate_Int()
    {
      int date = 16;
      Order testOrder = new Order("title", "an order", 30 ,date);
      int result = testOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAllMethod_ShowsEmptyList_OrderList()
    {
      List<Order> testList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetAllMethod_ReturnOrders_OrderList()
    {
      Order testOrder = new Order("title", "things to do", 30, 16);
      List<Order> testList = new List<Order> {testOrder};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(testList, result);
    }
  }
}