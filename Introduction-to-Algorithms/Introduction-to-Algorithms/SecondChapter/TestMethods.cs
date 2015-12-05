using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Algorithms.SecondChapter
{
    public class TestMethods
    {
        public static void TestRecursiveLinearSearch()
        {
            Random rand = new Random();

            int n = 10;
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(1, 50);
            }

            outPutArray(a, n);

            int x = a[rand.Next(1, n)];

            int resultIndex = SearchItems.RecursiveLinearSearch(a, n, 0, x);

            Console.WriteLine(" x = " + x + " index = " + resultIndex);
        }

        public static void TestSentitelLinearSearch()
        {
             Random rand = new Random();

            int n = 10;
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(1, 50);
            }

            outPutArray(a, n);

            int x = a[rand.Next(1, n)];

            int resultIndex = SearchItems.SentitelLinearSearch(a, n, x);

            Console.WriteLine(" x = " + x + " index = " + resultIndex);
        }

        public static void TestBetterLinearSearch()
        {
            Random rand = new Random();

            int n = 10;
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(1, 50);
            }

            outPutArray(a, n);

            int x = a[rand.Next(1, n)];

            int resultIndex = SearchItems.BetterLinearSearch(a, n, x);

            Console.WriteLine(" x = " + x + " index = " + resultIndex);
        }

        public static void TestLinearSearch()
        {
            Random rand = new Random();

            int n = 10;
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(1, 50);
            }

            outPutArray(a, n);

            int x = a[rand.Next(1, n)];

            int resultIndex = SearchItems.LinearSearch(a, n, x);

            Console.WriteLine(" x = " + x + " index = " + resultIndex);
        }

        private static void outPutArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
