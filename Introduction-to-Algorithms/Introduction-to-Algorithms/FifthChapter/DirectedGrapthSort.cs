using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Algorithms.FifthChapter
{
    public class DirectedGrapthSort
    {
        public static List<int> TopologicalSort(int n, int[,] graph)
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

            List<int> linearOrdering = new List<int>();

            while (next.Count > 0)
            {
                int u = next[0];
                next.RemoveAt(0);

                linearOrdering.Add(u);
                List<int> listAdjacentVertex = GetAdjacentVertex(u, n, graph);

                foreach (int adjacentVertex in listAdjacentVertex)
                {
                    in_degree[adjacentVertex]--;
                    if (in_degree[adjacentVertex] == 0)
                    {
                        next.Insert(0, adjacentVertex);
                    }
                }
                
            }

            return linearOrdering;

            
            
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
