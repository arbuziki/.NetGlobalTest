using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Algorithms
    {
        [Test]
        public void InsertionSortingTest()
        {
            int[] A = {5, 2, 4, 6, 1, 3};

            InsertionSorting.Sort(A);
        }
    }
}
