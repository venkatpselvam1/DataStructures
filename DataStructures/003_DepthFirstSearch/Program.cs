using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_DepthFirstSearch
{
    class Program
    {
        public class Graph
        {
            bool[] rec;
            int[,] graph;
            public Graph(int n)
            {
                this.graph = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    this.graph[i, i] = 1;
                }
                this.rec = new bool[n];
            }
            public void AddEdge(int a, int b)
            {
                graph[a, b] = 1;
                graph[b, a] = 1;
            }
            public void DeleteEdge(int a, int b)
            {
                graph[a, b] = 0;
                graph[b, a] = 0;
            }

            public void Print()
            {
                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    for (int j = 0; j < graph.GetLength(1); j++)
                    {
                        Console.Write(graph[i, j] + ", ");
                    }

                    Console.WriteLine();
                }
            }
            public void Dfs(int n)
            {
                rec[n] = true;
                Console.WriteLine(n);
                for(int i = 0; i < graph.GetLength(0); i++)
                {
                    if (graph[n, i] == 1 && !rec[i])
                    {
                        rec[i] = true;
                        Dfs(i);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            var graph = new Graph(5);
            graph.AddEdge(0, 1);
            graph.AddEdge(2, 1);
            graph.AddEdge(2, 3);
            graph.AddEdge(4, 3);
            graph.AddEdge(4, 0);
            graph.AddEdge(4, 1);
            graph.AddEdge(3, 1);
            graph.Print();
            Console.WriteLine("DFS for 2");
            graph.Dfs(2);
        }
    }
}
