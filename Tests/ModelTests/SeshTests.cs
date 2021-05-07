using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class SeshTests
  {
    [TestMethod]
    public void SeshCtor_MakesInstOf_Sesh()
    {
      Sesh s = new();
      Assert.AreEqual(typeof(Sesh), s.GetType());
    }
    [TestMethod]
    public void NewSesh_Has_EmptyOrder()
    {
      Sesh s = new();
      List<BakedGood> l = new() { };
      Assert.AreEqual(l.GetType(), s.Order.GetType());
      Assert.AreEqual(l.Count, s.Order.Count);
    }
    [TestMethod]
    public void SeshAddPastry_AddsPastry_ToOrder()
    {
      Sesh s = new();
      Pastry p = new();
      s.Add(p);
      Assert.AreEqual(1, s.Order.Count);
      Assert.AreEqual(typeof(Pastry), s.Order[0].GetType());
    }
    [TestMethod]
    public void SeshAddPastry_FindsSubtotal_2()
    {
      Sesh s = new();
      Pastry p = new();
      s.Add(p);
      Assert.AreEqual(s.Subtotal, 2);
    }
    [TestMethod]
    public void SeshAddPastry3Times_FindsSubtotal_5not6()
    {
      Sesh s = new();
      s.Add(new Pastry());
      s.Add(new Pastry());
      s.Add(new Pastry());
      Assert.AreEqual(5, s.Subtotal);
    }
    [TestMethod]
    public void SeshAddBread3Times_FindsSubtotal_10not15()
    {
      Sesh s = new();
      s.Add(new Bread());
      s.Add(new Bread());
      s.Add(new Bread());
      Assert.AreEqual(10, s.Subtotal);
    }
    [TestMethod]
    public void SeshAdd3pastry6bread_FindsSubtotal_25not36()
    {
      Sesh s = new();
      s.Add(new Pastry());
      s.Add(new Pastry());
      s.Add(new Pastry());
      s.Add(new Bread());
      s.Add(new Bread());
      s.Add(new Bread());
      s.Add(new Bread());
      s.Add(new Bread());
      s.Add(new Bread());
      Assert.AreEqual(25, s.Subtotal);
    }
  }
}
