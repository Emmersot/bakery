using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Models;


namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {    
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("A Pastry cost $2 and Bread cost $5");
      Console.WriteLine("Every third order is $1 off for Pastries");
      Console.WriteLine("And buy 3 get 1 free for Bread");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("Would you like to buy Bread? ['Y' for yes, 'N' for no]");
      string makeBread = Console.ReadLine().ToUpper();
      if (makeBread == "Y" || makeBread == "y")
      {
        Console.WriteLine("Bread is $5, buy 3 get 1 free");
        Console.WriteLine("How much Bread would you like?");
        int breadOrder = int.Parse(Console.ReadLine());
        Bread userBread = new Bread(breadOrder);
        Console.WriteLine("For " + userBread.Amount + " loafs of bread your total is $" + userBread.BreadCalc());
      }
      else
      {
        Console.WriteLine("Would you like to buy Pastries? ['Y' for yes, 'N' for no]");
        string makePastry = Console.ReadLine().ToUpper();
        if (makePastry == "Y" || makePastry == "y")
        {
          Console.WriteLine("Pastries are $2, buy 3 get 1 for free");
          Console.WriteLine("How many Pastries would you like?");
          int pastryOrder = int.Parse(Console.ReadLine());
          Pastry userPastry = new Pastry(pastryOrder);
          Console.WriteLine("For " + userPastry.Amount + " Pastries your total is $" + userPastry.PastryCalc());
        }
        else
        {
          Main();
        }
      }
    }
  }
}