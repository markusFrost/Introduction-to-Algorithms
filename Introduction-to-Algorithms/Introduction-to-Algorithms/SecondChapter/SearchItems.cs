using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Algorithms.SecondChapter
{
    public class SearchItems
    {
       private const int NOT_FOUND = -1;

        // a - array, n - count of items, x - searchable value

        public static int RecursiveLinearSearch(int[] a, int n, int i, int x)
        {
            if ( i >= n)
            {
                return NOT_FOUND;
            }
            else if (a[i] == x)
            {
                return i;
            }
            else
            {
                return RecursiveLinearSearch(a, n, i + 1, x);
            }

        }

        public static int SentitelLinearSearch(int[] a, int n, int x)
        {
            int last = a[n - 1];
            a[n - 1] = x;

            int i = 0;
            while (a[i] != x)
            {
                i++;
            }

            a[n - 1] = last;

            if (i < n || a[n - 1] == x)
            {
                return i;
            }

            return NOT_FOUND;
        }

        public static int BetterLinearSearch(int[] a, int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }

            return NOT_FOUND;
        }

        public static int LinearSearch(int[] a, int n, int x)
        {
            int answer = NOT_FOUND;

            for ( int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    answer = i;
                }
            }
            return answer;
        }
    }
}
