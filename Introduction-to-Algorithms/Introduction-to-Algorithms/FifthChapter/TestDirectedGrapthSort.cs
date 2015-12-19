using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Algorithms.FifthChapter
{
    public class TestDirectedGrapthSort
    {
        public static  void TestTopologicalSort()
        {
            const int n = 14;
            int[,] graph = new int[n, n];

            // fill graph
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    graph[i, j] = 0;
                }
            }

            Vertex item;
            List<Vertex> list = new List<Vertex>();

            item = new Vertex();
            item.I = 1;
            item.J = 3;
            list.Add(item);


            item = new Vertex();
            item.I = 2;
            item.J = 4;
            list.Add(item);

            item = new Vertex();
            item.I = 3;
            item.J = 4;
            list.Add(item);

            item = new Vertex();
            item.I = 3;
            item.J = 5;
            list.Add(item);

            item = new Vertex();
            item.I = 4;
            item.J = 6;
            list.Add(item);

            item = new Vertex();
            item.I = 5;
            item.J = 6;
            list.Add(item);

            item = new Vertex();
            item.I = 6;
            item.J = 7;
            list.Add(item);

            item = new Vertex();
            item.I = 6;
            item.J = 11;
            list.Add(item);

            item = new Vertex();
            item.I = 7;
            item.J = 8;
            list.Add(item);


            item = new Vertex();
            item.I = 8;
            item.J = 13;
            list.Add(item);

            item = new Vertex();
            item.I = 9;
            item.J = 10;
            list.Add(item);

            item = new Vertex();
            item.I = 10;
            item.J = 11;
            list.Add(item);

            item = new Vertex();
            item.I = 11;
            item.J = 12;
            list.Add(item);

            item = new Vertex();
            item.I = 12;
            item.J = 13;
            list.Add(item);

            item = new Vertex();
            item.I = 13;
            item.J = 14;
            list.Add(item);

            foreach (Vertex it in list)
            {
                graph[it.I - 1,it.J - 1] = 1;
            }


            DirectedGrapthSort.TopologicalSort(n, graph);

            

           
        }

      
    }

    public class Vertex
    {
        public int I { get; set; }
        public int J { get; set; }
    }
}
