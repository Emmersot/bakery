using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryCalc_CostOnePastryNoDiscount_Int()
    {
      
      int pastryAmount = 1;
      double pastryCost = 2;
      
      Pastry pastryOrder = new Pastry(pastryAmount);
      
      Assert.AreEqual(pastryCost, pastryOrder.PastryCalc());
    }
    [TestMethod]
    public void PastryCalc_CostTwoPastryNoDiscount_Int()
    {
      
      int pastryAmount = 2;
      double pastryCost = 4;
      
      Pastry pastryOrder = new Pastry(pastryAmount);
      
      Assert.AreEqual(pastryCost, pastryOrder.PastryCalc());
    }
    [TestMethod]
    public void PastryCalc_CostThreePastriesIsDiscounted_Int()
    {
      
      int pastryAmount = 3;
      double pastryCost = 5;
      
      Pastry pastryOrder = new Pastry(pastryAmount);
      
      Assert.AreEqual(pastryCost, pastryOrder.PastryCalc());
    }
    [TestMethod]
    public void PastryCalc_CostSixPastriesIsDiscounted_Int()
    {
      
      int pastryAmount = 6;
      double pastryCost = 10;
      
      Pastry pastryOrder = new Pastry(pastryAmount);
      
      Assert.AreEqual(pastryCost, pastryOrder.PastryCalc());
    }
  }
}
