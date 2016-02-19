using Algorithms;
using Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.Sort
{
    [TestClass()]
    public class MergeTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] data = { 1, 4, 1, 2, 7, 5, 2 };
            Insertion.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }

        [TestMethod()]
        public void Sort1000ShuffledIntegers()
        {
            int[] data = AlgorithmsTests.Sort.Data.GetSuffleIntegers(1000);
            Merge.Sort(data);
            Assert.IsTrue(Utils.IsSorted(data));
        }
    }
}