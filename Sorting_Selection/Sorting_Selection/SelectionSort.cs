using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Selection
{
    class SelectionSort
    {
        public static void SortSelection(int[] A)
        {
            //find smallest or biggest element
            //compare each other
            //replace

            int smallest = 0;
            int c = 0;

            for (int i = 0; i < A.Length; i++)
            {
                smallest = i;

                //find smallest
                for (int j = i + 1; j < A.Length; j++)
                    if (A[j] < A[smallest])
                        smallest = j;

                //replace in remained elaments the smallest
                c = A[i];
                A[i] = A[smallest];
                A[smallest] = c;
            }
        }
    }
}
