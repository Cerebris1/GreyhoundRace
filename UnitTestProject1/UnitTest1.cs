using System;
using GreyhoundRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Punter newPunter = new Joe();

        [TestMethod]
        public void TestInstantiation()
        {
            int ExpectedCash = 50;
            int ActualCash = newPunter.Cash;
            Assert.AreEqual(ExpectedCash, ActualCash);
        }
    }
}
