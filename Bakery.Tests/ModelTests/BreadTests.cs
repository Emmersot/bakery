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
      
      int breadAmount = 1;
      double breadCost = 5;
      
      Bread breadOrder = new Bread(breadAmount);
      
      Assert.AreEqual(breadCost, breadOrder.BreadCalc());
    }
    [TestMethod]
    public void BreadCalc_CostTwoLoafsNoDiscount_Int()
    {
      
      int breadAmount = 2;
      double breadCost = 10;
      
      Bread breadOrder = new Bread(breadAmount);
      
      Assert.AreEqual(breadCost, breadOrder.BreadCalc());
    }
    [TestMethod]
    public void BreadCalc_CostThirdLoafsIsDiscounted_Int()
    {
      
      int breadAmount = 3;
      double breadCost = 10;
      
      Bread breadOrder = new Bread(breadAmount);
      
      Assert.AreEqual(breadCost, breadOrder.BreadCalc());
    }
    public void BreadCalc_CostSixLoafsIsDiscounted_Int()
    {
      
      int breadAmount = 6;
      double breadCost = 20;
      
      Bread breadOrder = new Bread(breadAmount);
      
      Assert.AreEqual(breadCost, breadOrder.BreadCalc());
    }
  }
}