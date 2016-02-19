using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort.Tests
{
    [TestClass()]
    public class QuickTests
    {
        [TestMethod()]
        public void SortTestTwoInReveredOrder()
        {
            int[] data = { 2, 1 };
            Quick.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }

        [TestMethod()]
        public void SortTestTwoIdentical()
        {
            int[] data = { 1, 1 };
            Quick.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }

        [TestMethod()]
        public void SortTestTwoCorrectOrder()
        {
            int[] data = { 1, 2 };
            Quick.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }

        [TestMethod()]
        public void SortTestWithDuplicate()
        {
            int[] data = { 2, 1, 3, 2, 1, 7, 1 };
            Quick.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }
    }
}