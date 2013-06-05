using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8.gsmCall;
namespace _12.GSMCallHistoryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GSM newTestGsm = new GSM();
            DateTime date1 = DateTime.Now;
            newTestGsm.CallHistory.Add(new Call(date1, 0878547866, 180, "Kiril"));
            newTestGsm.CallHistory.Add(new Call(date1, 0878256567, 120, "Tosho"));
            newTestGsm.CallHistory.Add(new Call(date1, 0898321455, 120, "Ogi"));
            newTestGsm.CallHistory.Add(new Call(date1, 0878547866, 240, "Kiril"));

            Assert.AreEqual(4.07m, newTestGsm.CalculateTotalPrice(0.37m));

            newTestGsm.RemoveCallMaxValue();
            Assert.AreEqual(2.59m, newTestGsm.CalculateTotalPrice(0.37m));

            newTestGsm.RemoveCallMinValue();
            Assert.AreEqual(1.85m, newTestGsm.CalculateTotalPrice(0.37m));

          
 
        }
    }
}
