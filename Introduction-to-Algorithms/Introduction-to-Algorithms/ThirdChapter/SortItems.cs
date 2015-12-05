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
