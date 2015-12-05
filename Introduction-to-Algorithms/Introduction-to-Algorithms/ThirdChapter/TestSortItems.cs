using Introduction_to_Algorithms.SecondChapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Algorithms.ThirdChapter
{
    public class TestSortItems
    {
        public static void TestSelectionSort()
        {
            int n = 10;
            int[] a = generateArray(n);
            TestMethods.outPutArray(a, n);

            SortItems.SelectionSort( ref a, n);

            TestMethods.outPutArray(a, n);

        }

        private static int[] generateArray(int n)
        {
            Random rand = new Random();

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(1, 50);
            }

            return a;
        }
    }
}
