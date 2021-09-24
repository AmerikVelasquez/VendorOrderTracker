using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
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
  }
}