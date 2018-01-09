using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class InsertionSorting
    {
        public static void Sort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int key = A[i];

                int j = i - 1;

                while (j > -1 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }

                A[j + 1] = key;
            }
        }
    }
}
