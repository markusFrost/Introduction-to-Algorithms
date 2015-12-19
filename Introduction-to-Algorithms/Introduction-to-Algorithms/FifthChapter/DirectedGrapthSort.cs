using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Algorithms.FifthChapter
{
    public class DirectedGrapthSort
    {
        public static void TopologicalSort(int n, int[,] graph)
        {
            int[] in_degree = new int[n];

            for (int i = 0; i < n; i++)
            {
                in_degree[i] = 0;
            }

            for (int numberVertex = 0; numberVertex < n; numberVertex++)
            {
                List<int> listAdjacentVertex = GetAdjacentVertex(numberVertex, n, graph);

                foreach ( int adjacentVertex in listAdjacentVertex)
                {
                    in_degree[adjacentVertex]++;
                }
            }

            List<int> next = new List<int>(); // we need to find zero vertex automaticly

            for (int i = 0; i < n; i++)
            {
                if (in_degree[i] == 0)
                {
                    next.Add(i);
                }
            }

            int a = 0;

            
            
        }

        private static List<int> GetAdjacentVertex(int numberVertex, int n, int[,] graph)
        {
            List<int> listAdjacentVertex = new List<int>();
            for (int j = 0; j < n; j++)
            {
                if (graph[numberVertex, j] > 0)
                {
                    listAdjacentVertex.Add(j);
                }
            }
            return listAdjacentVertex;
        }
    }
}
