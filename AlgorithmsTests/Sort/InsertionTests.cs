using System.Diagnostics;
using Algorithms;
using Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.Sort
{
    [TestClass()]
    public class InsertionTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] data = { 1, 4, 1, 2, 7, 5, 2 };
            Insertion.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }

        public void Sort1000ShuffledIntegers()
        {
            int[] data = Data.GetSuffleIntegers(1000);

            Stopwatch st = new Stopwatch();
            st.Start();
            Insertion.Sort(data);
            st.Stop();


            Assert.IsTrue(Utils.IsSorted(data));
        }
    }
}