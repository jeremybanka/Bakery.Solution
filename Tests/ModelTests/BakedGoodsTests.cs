using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void SampleMethod_Does_Thing()
    {
      bool output = Bread.Method();
      Assert.AreEqual(output, true);
    }
  }

}
