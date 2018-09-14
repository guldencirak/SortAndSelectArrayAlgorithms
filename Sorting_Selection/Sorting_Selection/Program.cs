using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 5, 6, 3, 1, 8, 7, 2, 4 };
            //replace each other
            //BubleSort.SortBuble(A);

            //find smallest and replace with smallest in each other
            //SelectionSort.SortSelection(A);

            //
            QuickSort.SortQuick(A);
        }
    }
}
