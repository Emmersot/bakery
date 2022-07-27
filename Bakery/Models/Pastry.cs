using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  //1 = $2
  //if /3 then -$1
  public class Pastry
  {
    public int Amount { get; set; }
    public int Price { get; set; }

    public Pastry(int amount)
    {
      Amount = amount;
    }

    public void PastryCalc()
    {
      //while incrementing buy 1 if the index is divisible by 3 it will add 1 instead of 2 to Price
      for (int i = 1; i <= Amount; i++)
      {
        if (i % 3 == 0)
        {
          Price += 1;
        }
        else
        {
          {
            Price += 2;
          }
        }
      }
    }
  }
}