using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Dziala()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
