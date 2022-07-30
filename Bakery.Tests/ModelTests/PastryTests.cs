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
  }
}
