using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Selection
{
    /// <summary>
    /// Complexity: O(N^2)
    /// </summary>
    class BubleSort
    {
        public static void SortBuble(int[] A)
        {
            //5 6 3 1 8 7 2 4
            //N-1,N-1,N-3,N-4...

            int a = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 1; j < A.Length; j++)
                {
                    if (A[j] < A[j - 1])
                    {
                        a = A[j - 1];
                        A[j - 1] = A[j];
                        A[j] = a;
                    }
                }
            }
        }
    }
}
