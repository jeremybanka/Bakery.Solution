using System.Collections.Generic;

namespace Bakery.Models
{
  abstract public class BakedGood
  {
    public int Price { get; set; }
    public Dictionary<int, int> Discounts { get; }
  }
  public class Bread : BakedGood
  {
    public Bread()
    {
      Price = 5;
      Discounts.Add(3, 10);
    }
    public static bool Method()
    {
      return true;
    }
  }
  public class Pastry : BakedGood
  {
    public Pastry()
    {
      Price = 2;
      Discounts.Add(3, 5);
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


