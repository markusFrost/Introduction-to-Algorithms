using Introduction_to_Algorithms.SecondChapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Algorithms.ThirdChapter
{
    public class SortItems
    {
        private const int NOT_FOUND = -1;

        public static int RecursiveBinarySearch(int[] a, int p, int r, int x)
        {
            if (p > r)
            {
                return NOT_FOUND;
            }
            int q = (p + r) / 2;

            if (a[q] == x)
            {
                return q;
            }
            else if (a[q] > x)
            {
                return RecursiveBinarySearch(a, p, q - 1, x);
            }
            else
            {
                return RecursiveBinarySearch(a, q + 1, r, x);
            }
        }

        public static int BinarySearch(int[] a, int n, int x)
        {
            int p = 0;
            int r = n - 1;
            int q = 0;

            while (p <= r)
            {
                q = (p + r) / 2;

                if (a[q] == x)
                {
                    return q;
                }
                else if (a[q] > x)
                {
                    r = q - 1;
                }
                else
                {
                    p = q + 1;
                }
            }
            return NOT_FOUND;
        }

        public static void SelectionSort ( ref int[]a, int n)
        {
            int smallest = 0;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[smallest])
                    {
                        smallest = j;
                    }
                }

                int c = a[i];
                a[i] = a[smallest];
                a[smallest] = c;
            }
        }

        
    }
}
