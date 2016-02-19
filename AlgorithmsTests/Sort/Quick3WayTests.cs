using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Sort.Tests
{
    [TestClass()]
    public class Quick3WayTests
    {
        [TestMethod()]
        public void SortTestTwoInReveredOrder()
        {
            int[] data = { 2, 1 };
            Quick3Way.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }

        [TestMethod()]
        public void SortTestTwoIdentical()
        {
            int[] data = { 1, 1 };
            Quick3Way.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }

        [TestMethod()]
        public void SortTestTwoCorrectOrder()
        {
            int[] data = { 1, 2 };
            Quick3Way.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }

        [TestMethod()]
        public void SortTestWithDuplicate()
        {
            int[] data = { 2,1,3,2,1,7,1 };
            Quick3Way.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }
    }
}