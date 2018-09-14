using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Selection
{
    class QuickSort
    {
        //get the middlest element
        //divide & conquer

        public static void SortQuick(int[] A)
        {
            A = new int[] { 9, 4, 6, 7, 3, 8, 1 };

            /*
        Diziden herhangi bir elemanı pivot(kilit) eleman olarak seçer.
        Diziyi, pivot elemandan küçük olan bütün elemanlar pivot elemanın önüne, pivot elemandan büyük olan bütün elemanlar pivot elemanın arkasına gelecek biçimde düzenler.
        Pivot elemana eşit olan sayılar sıralamanın küçükten büyüğe ya da büyükten küçüğe olmasına bağlı olarak pivot elemanın her iki tarafına da geçebilir.
        Quicksort algoritması özyineli(recursive) çağrılarak, oluşan küçük diziler tekrar sıralanır.
        Algoritma eleman sayısı sıfır olan bir alt diziye ulaşana kadar bu işlem devam eder.
        Eleman sayısı sıfır olan bir alt diziye ulaşıldığında algoritma bu dizinin sıralanmış olduğunu varsayar ve sıralama işlemi tamamlanmış olur.
             */

            int middle = A[A.Length / 2];


            
        }
    }
}
