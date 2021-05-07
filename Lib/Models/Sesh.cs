using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Sesh
  {

    public List<BakedGood> Order { get; }
    public int Subtotal { get; set; }

    public Sesh()
    {
      Order = new() { };
    }
    public void Add(BakedGood g)
    {
      Order.Add(g);
      Subtotal = CalculateSubtotal();
    }
    public int CalculateSubtotal()
    {
      int runningTotal = 0;
      Dictionary<Type, (int count, Discount deal)> talesForDiscounts = new();
      foreach (BakedGood bg in Order)
      {
        Type typeOfBakedGood = bg.GetType();
        try
        {
          (int count, Discount deal) = talesForDiscounts[typeOfBakedGood];
          count++;
          talesForDiscounts[typeOfBakedGood] = (count, deal);
        }
        catch (KeyNotFoundException)
        {
          talesForDiscounts.Add(typeOfBakedGood, (1, bg.Discount));
        }
        runningTotal += bg.Price;
      }
      foreach (KeyValuePair<Type, (int, Discount)> taleForDiscount in talesForDiscounts)
      {
        (int count, Discount deal) = taleForDiscount.Value;
        double d = count / deal.Tale;
        int discountMultiplier = int.Parse(Math.Round(d).ToString());
        int finalDiscount = deal.Savings * discountMultiplier;
        runningTotal -= finalDiscount;
      }
      return runningTotal;
    }
  }
}

