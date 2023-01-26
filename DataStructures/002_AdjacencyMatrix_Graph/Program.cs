using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_AdjacencyMatrix_Graph
{
    class Program
    {
        public class Graph
        {
            int[,] graph;
            public Graph(int n)
            {
                this.graph = new int[n, n];
                for(int i = 0; i < n; i++)
                {
                    this.graph[i, i] = 1;
                }
            }
            public void AddEdge(int a, int b)
            {
                graph[a, b] = 1;
                graph[b, a] = 1;
            }
            public void DeleteEdge(int a , int b)
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
                        Console.Write(graph[i, j]+", ");
                    }

                    Console.WriteLine();
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
        }
    }
}
