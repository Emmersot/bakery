using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }
    public int Price { get; set; }

    public Bread(int amount)
    {
      Amount = amount;
    }

    public void BreadCalc()
    {
      //while incrementing buy 1 if the index is divisible by 3 it wont add to Price
      for (int i = 1; i <= Amount; i++)
      {
        if (i % 3 == 0)
        {
          Price += 0;
        }
        else
        {
          {
            Price += 5;
          }
        }
      }
    }
  }
}