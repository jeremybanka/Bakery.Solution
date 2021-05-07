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
      List<BakedGood> l = new();
      Assert.AreEqual(s.Order.GetType(), l.GetType());
      Assert.AreEqual(s.Order.Count, l.Count);
    }
  }
}
