using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BreathFirstSearch
{
    class Program
    {
        public class Graph
        {
            int[,] graph;
            public Graph(int n)
            {
                this.graph = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    this.graph[i, i] = 1;
                }
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
            bool[] rec;
            public void Bfs(int n)
            {
                rec = new bool[graph.GetLength(0)];
                BfsRec(n);
            }
            private void BfsRec(int n)
            {
                Console.WriteLine("BFS for "+n);
                var q = new Queue<int>();
                q.Enqueue(n);
                rec[n] = true;
                while (q.Count() > 0)
                {
                    var t = q.Dequeue();
                    Console.WriteLine(t);
                    for (int j = 0; j < graph.GetLength(0); j++)
                    {
                        if (graph[t, j] == 1 && !rec[j])
                        {
                            rec[j] = true;
                            q.Enqueue(j);
                        }
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
            graph.Bfs(4);
        }
    }
}
