using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Algorithms.SecondChapter
{
    public class SearchItems
    {
        // a - array, n - count of items, x - searchable value
        public static int LinearSearch(int[] a, int n, int x)
        {
            const int NOT_FOUND = -1;
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
