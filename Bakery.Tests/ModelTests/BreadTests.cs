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
    [TestMethod]
    public void BreadCalc_CostTwoLoafsNoDiscount_Int()
    {
      //Arrange
      int breadAmount = 2;
      double breadCost = 10;
      //Act
      Bread breadOrder = new Bread(breadAmount);
      //Assert
      Assert.AreEqual(breadCost, breadOrder.BreadCalc());
    }
    [TestMethod]
    public void BreadCalc_CostThirdLoafsIsDiscounted_Int()
    {
      //Arrange
      int breadAmount = 3;
      double breadCost = 10;
      //Act
      Bread breadOrder = new Bread(breadAmount);
      //Assert
      Assert.AreEqual(breadCost, breadOrder.BreadCalc());
    }
    public void BreadCalc_CostSixLoafsIsDiscounted_Int()
    {
      //Arrange
      int breadAmount = 6;
      double breadCost = 20;
      //Act
      Bread breadOrder = new Bread(breadAmount);
      //Assert
      Assert.AreEqual(breadCost, breadOrder.BreadCalc());
    }
  }
}