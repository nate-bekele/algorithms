using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sort;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort.Tests
{
    [TestClass()]
    public class ShellTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] data = { 1, 4, 1, 2, 7, 5, 2 };
            Shell.Sort(data);

            Assert.IsTrue(Utils.IsSorted(data));
        }

    }
}