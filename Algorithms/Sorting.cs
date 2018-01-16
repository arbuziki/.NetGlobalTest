using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Sorting
    {
        public static void InsertionSort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                var key = A[i];

                int j = i - 1;

                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    A[j] = key;

                    j--;
                }
            }
        }

        public static void MergeSort(int[] A)
        {
            MergeSort(A, 0, A.Length);
        }
        
        private static void MergeSort(int[] A, int startIndex, int count)
        {
            if (count < 2)
                return;

            int half = count / 2;

            if (half == 0)
            {
                Debugger.Break();
            }

            int firstCount = half;
            int secondCount = count - half;

            int firstIndex = startIndex;
            int secondIndex = startIndex + firstCount;

            MergeSort(A, startIndex, firstCount);
            MergeSort(A, secondIndex, secondCount);

            int lastFirstIndex = startIndex + firstCount;
            int lastSecondIndex = startIndex + count;

            int k = 0;
            int[] sorted = new int[count];

            while (firstIndex < lastFirstIndex && secondIndex < lastSecondIndex)
            {
                if (A[secondIndex] > A[firstIndex])
                {
                    sorted[k] = A[firstIndex];
                    firstIndex++;
                }
                else
                {
                    sorted[k] = A[secondIndex];
                    secondIndex++;
                }
                k++;
            }

            //Одна из последовательностей закончилась - остаток второй надо дописать в конец

            while (firstIndex < lastFirstIndex)
            {
                sorted[k] = A[firstIndex];
                k++;
                firstIndex++;
            }

            while (secondIndex < lastSecondIndex)
            {
                sorted[k] = A[secondIndex];
                k++;
                secondIndex++;
            }

            k = 0;

            for (int i = startIndex; i < startIndex + count; i++)
            {
                A[i] = sorted[k++];
            }
        }
    }
}
