using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1.MethodThatAsksTheUser;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMehod]
        public void TestMethod1()
        {
            int b = MethodThatAsksTheUser.testc(1,2);
            Assert.AreEqual(3,b );
        }
    }
}
