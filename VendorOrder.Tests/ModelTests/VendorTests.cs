using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;


namespace VendorOrder.Tests
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
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "vendornametest";
      Vendor newVendor = new Vendor(vendorName);

      string result = newVendor.VendorName;
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void SetVendorName_SetVendorName_String()
    {
      string vendorName = "test3";
      Vendor newVendor = new Vendor(vendorName);

      string updatedVendorName = "newtest";
      newVendor.VendorName = updatedVendorName;
      string result = newVendor.VendorName;
      Assert.AreEqual(updatedVendorName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> { };

      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_VendorsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string vendorName = "suzie";
      Vendor newVendor = new Vendor(vendorName);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendorName01 = "bakeshop";
      string vendorName02 = "theunbakedshop";
      Vendor newVendor1 = new Vendor(vendorName01);
      Vendor newVendor2 = new Vendor(vendorName02);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_ConnectsOrderWithCorrectVendor_OrderList()
    {
      string description = "testorder1";
      Order newOrder = new Order(description);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "bakedshop";
      Vendor newVendor = new Vendor(vendorName);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}