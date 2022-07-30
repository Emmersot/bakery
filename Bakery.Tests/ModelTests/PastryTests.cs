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
      //Arrange
      int pastryAmount = 1;
      double pastryCost = 2;
      //Act
      Pastry pastryOrder = new Pastry(pastryAmount);
      //Assert
      Assert.AreEqual(pastryCost, pastryOrder.PastryCalc());
    }
    [TestMethod]
    public void PastryCalc_CostTwoPastryNoDiscount_Int()
    {
      //Arrange
      int pastryAmount = 2;
      double pastryCost = 4;
      //Act
      Pastry pastryOrder = new Pastry(pastryAmount);
      //Assert
      Assert.AreEqual(pastryCost, pastryOrder.PastryCalc());
    }
    [TestMethod]
    public void PastryCalc_CostThreePastriesIsDiscounted_Int()
    {
      //Arrange
      int pastryAmount = 3;
      double pastryCost = 5;
      //Act
      Pastry pastryOrder = new Pastry(pastryAmount);
      //Assert
      Assert.AreEqual(pastryCost, pastryOrder.PastryCalc());
    }
  }
}
