using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int ourCounter;
            _4.CountHowManyTimesGivenNumberAppears.CountHowManyTimesGivenNumberAppears.CountHowManyTimesGivenNumber(out ourCounter, 2);
            Assert.AreEqual(4, ourCounter);
        }
    }
}
