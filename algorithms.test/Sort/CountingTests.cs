using System;
using System.Diagnostics;
using Algorithms.Sort;
using Algorithms.Test.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Search.Tests
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