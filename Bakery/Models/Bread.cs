using System;

namespace Bakery.Models
{
  public class Bread
  {
    private static int _Price = 5;
    private int _Discount = 5;
    public int Amount { get; set; }

    public int Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Bread(int amount)
    {
      _Price = Price;
      _Discount = 5;
      Amount = amount;
    }

    public int BreadCalc()
    {
      int breadTotal = 0;
      for (int index = 0; index <= Amount; index++)
      {
        if (index == 0)
        {
          breadTotal += 0;
        }
        else if (index % 3 == 0)
        {
          breadTotal += 0;
        }
        else
        {
          breadTotal += _Price;
        }
      }
      return breadTotal;
    }
  }
}