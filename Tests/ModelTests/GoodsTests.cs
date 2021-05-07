using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class GoodsTests
  {
    [TestMethod]
    public void PastryCtor_MakesInstOf_Pastry()
    {
      Pastry p = new();
      Assert.AreEqual(typeof(Pastry), p.GetType());
    }
    [TestMethod]
    public void BreadCtor_MakesInstOf_Bread()
    {
      Bread b = new();
      Assert.AreEqual(typeof(Bread), b.GetType());
    }
  }
}
