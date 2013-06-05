using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _6.IPhone4S;

namespace _7.GSMTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GSM[] newGsm = new GSM[5];
            string[] models = { "Nokia", "BlackBerry", "Samsung", "LG", "Iphone s4", };
            decimal[] prices = { 111, 222, 333, 3443, 2323 };
            string[] owners = { "Boicho", "Shosho", "Rado", "Stamat", "Qnko" };
            string[] manufacturers = { "Rusia", "China", "Bulgaria", "Fakulteto", "Izrael", };
            for (int i = 0; i < newGsm.Length; i++)
            {
                newGsm[i] = new GSM(owners[i], manufacturers[i], models[i], prices[i]);
              
            }
            Assert.AreEqual("China",newGsm[1].Manufacturer);
            Assert.AreEqual("Nokia", newGsm[0].Model);
            Assert.AreEqual("Bulgaria", newGsm[2].Manufacturer);
            Assert.AreEqual(-2323, newGsm[4].Price);
           
        }
    }
}
