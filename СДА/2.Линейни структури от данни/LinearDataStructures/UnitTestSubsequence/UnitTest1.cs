using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4.FindsLongestSubsequence;

namespace UnitTestSubsequence
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSequence()
        {
           List<int> newList = new List<int>();
           newList.Add(5);

            List<int> seuence = Subsequence.FindSubsequence(newList);

            Assert.AreEqual(5, seuence[0]);
            
        }

        [TestMethod]
        public void TestMethodSequence2()
        {
            List<int> list = new List<int>()
            {
                1, 2, 2, 2, 3, 2, 4, 5,5,5,5, 7, 8
            };

            List<int> seuence = Subsequence.FindSubsequence(list);

            for (int i = 0; i < seuence.Count; i++)
            {
                Assert.AreEqual(5, seuence[i]);   
            }
          
        }

        [TestMethod]
        public void TestMethodSequence3()
        {
            List<int> newList = new List<int>();
            newList.Add(15);
            newList.Add(5);
            newList.Add(5);
            List<int> seuence = Subsequence.FindSubsequence(newList);

            Assert.AreEqual(2, seuence.Count);

        }
    }
}
