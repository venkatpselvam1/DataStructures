using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_AdjacencyList_Graph
{
    class Program
    {
        public class Graph
        {
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            public void AddEdge(int a, int b)
            {
                AddKey(a, b);
                //if uni directed graph we don't need to add b,a
                AddKey(b, a);
            }

            private void AddKey(int a, int b)
            {
                if (graph.ContainsKey(a))
                {
                    graph[a].Add(b);
                }
                else
                {
                    graph.Add(a, new List<int>() { b });
                }
            }
            public void Print()
            {
                foreach (var item in graph.Keys)
                {
                    Console.WriteLine("For the node "+ item);
                    foreach (var val in graph[item])
                    {
                        Console.Write(val+" => ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            var graph = new Graph();
            // Adding edges one by one 
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 4);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            graph.Print();
        }
    }
}
