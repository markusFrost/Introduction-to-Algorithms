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

        public static void MergeSort(ref int[] a, int p, int r)
        {
            if (p >= r)
            {
                return;
            }
            int q = (p + r) / 2 ;

            MergeSort(ref a, p, q);
            MergeSort(ref a, q + 1, r);

            Merge( ref a, p, q, r);
        }

        private static void Merge( ref int[] a, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;

            int[] b = new int[n1 + 1];
            int[] c = new int[n2 + 1];

            int index = 0;

            for (int position = p; position <= q; position++)
            {
                b[index] = a[position];
                index++;
            }
            b[index] = Int32.MaxValue;

            index = 0;

            for (int position = (q + 1); position <= r; position++)
            {
                c[index] = a[position];
                index++;
            }
            c[index] = Int32.MaxValue;

            int i, j;
            i = j = 0;

            for (int k = p; k <=  r; k++)
            {
                if (b[i] <= c[j])
                {
                    a[k] = b[i];
                    i++;
                }
                else
                {
                    a[k] = c[j];
                    j++;
                }
            }
        }

        public static void InsertionSort(ref int[] a, int n)
        {
            int key = 0;
            int j = 0;

            for (int i = 1; i < n; i++)
            {
                key = a[i];
                j = i - 1;

                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }

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
