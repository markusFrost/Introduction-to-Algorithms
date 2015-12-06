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

        public static void TestInsertionSort()
        {
            int n = 10;
            int[] a = generateArray(n);
            TestMethods.outPutArray(a, n);

            SortItems.InsertionSort(ref a, n);

            TestMethods.outPutArray(a, n);
        }

        public static void TestRecursiveBinarySearch()
        {
            int n = 10;
            int[] a = generateArray(n);
            SortItems.SelectionSort(ref a, n);
            TestMethods.outPutArray(a, n);

            Random rand = new Random();
            int x = a[rand.Next(1, n)];

            int resultIndex = SortItems.RecursiveBinarySearch(a, 0, n - 1, x) + 1;

            Console.WriteLine("x = " + x + " index = " + resultIndex);


        }


        public static void TestBinarySearch()
        {
            int n = 10;
            int[] a = generateArray(n);
            SortItems.SelectionSort(ref a, n);
            TestMethods.outPutArray(a, n);

            Random rand = new Random();
            int x = a[rand.Next(1, n)];

            int resultIndex = SortItems.BinarySearch(a, n, x) + 1;

            Console.WriteLine("x = " + x + " index = " + resultIndex);


        }

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
