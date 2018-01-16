using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Sorting
    {
        [Test]
        public void InsertionSortingTest()
        {
            int[] A = {5, 2, 4, 6, 1, 3};

            Algorithms.Sorting.InsertionSort(A);
        }

        [Test]
        public void MergeSortingTest()
        {
            int[] A = {5, 2, 4, 6, 1, 3, 7, 9, 8};

            Algorithms.Sorting.MergeSort(A);
        }
    }
}
