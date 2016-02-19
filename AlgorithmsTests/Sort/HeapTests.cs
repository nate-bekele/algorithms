using Algorithms;
using Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests.Sort
{
    [TestClass()]
    public class HeapTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] data = { 1, 4, 2, 3 , 0, -1 };
            Heap.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }
    }
}