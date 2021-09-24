using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
     Vendor testVendor = new Vendor("name", "description");
     Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_ReturnsCorrectVendorName_String()
    {
      string name = "Aunt May";
      Vendor testVendor = new Vendor (name, "description");
      string result = testVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void Vendorconstructor_ReturnsCorrectVendorDescription_String()
    {
      string description = "SpiderMan's favorite place to eat";
      Vendor testVendor = new Vendor ("Aunt May", description);
      string result = testVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAllMethod_ShowsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> {};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAllMethod_ReturnsVendors_VendorList()
    {
      Vendor testVendor = new Vendor("Aunt May", "SpiderMan's favorite place to eat");
      List<Vendor> newList = new List<Vendor> {testVendor};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}