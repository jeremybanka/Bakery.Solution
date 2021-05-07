using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Discount
  {
    public int Tale { get; set; }
    public int Savings { get; set; }
    public Discount(int tale, int savings)
    {
      Tale = tale;
      Savings = savings;
    }
  }
  abstract public class BakedGood
  {
    public int Price { get; set; }
    public Discount Discount { get; set; }
  }
  public class Pastry : BakedGood
  {
    public Pastry()
    {
      Price = 2;
      Discount = new(3, 1);
    }
    public static bool Method()
    {
      return true;
    }
  }
  public class Bread : BakedGood
  {
    public Bread()
    {
      Price = 5;
      Discount = new(3, 5);
    }
    public static bool Method()
    {
      return true;
    }
  }
}

// letter
// scrabbleDictionary[letter] -> int
// scrabbleDictionary["A"] -> 1


