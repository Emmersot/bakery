using System;

namespace Bakery.Models
{
  public class Pastry
  {
    private static int _Price = 2;
    private int _Discount = 1;
    public int Amount { get; set; }

    public int Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Pastry(int amount)
    {
      _Price = Price;
      _Discount = 1;
      Amount = amount;
    }

    public int PastryCalc()
    {
      int pastryTotal = 0;
      for (int index = 0; index <= Amount; index++)
      {
        if (index == 0)
        {
          pastryTotal += 0;
        }
        else if (index % 3 == 0)
        {
          pastryTotal += 1;
        }
        else
        {
          pastryTotal += _Price;
        }   
      }
      return pastryTotal;
    }
  }
}