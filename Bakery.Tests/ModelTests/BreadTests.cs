using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCalc_CostOneLoafNoDiscount_Int()
    {
      //Arrange
      int breadAmount = 1;
      double breadCost = 5;
      //Act
      Bread breadOrder = new Bread(breadAmount);
      //Assert
      Assert.AreEqual(breadCost, breadOrder.BreadCalc());
    }
  }
}