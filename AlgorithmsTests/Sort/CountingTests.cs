using Algorithms;
using Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.Sort
{
    [TestClass()]
    public class CountingTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] data = {1, 4, 1, 2, 7, 5, 2};
            Counting.Sort(data, 0, 9);

            Assert.IsTrue(Utils.IsSorted(data));
        }
    }
}