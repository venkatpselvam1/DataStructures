using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_BreathFirstSearch_WithAdjacencyList
{
    class Program
    {
        public class Graph
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            List<int> rec = new List<int>();
            public void AddEdge(int a, int b)
            {
                AddToDict(a, b);
                AddToDict(b, a);
            }
            private void AddToDict(int a, int b)
            {
                if(dict.ContainsKey(a))
                {
                    dict[a].Add(b);
                }
                else
                {
                    dict.Add(a, new List<int>() { b });
                }
            }
            public void Bfs(int n)
            {
                var queue = new Queue<int>();
                rec.Add(n);
                queue.Enqueue(n);
                while (queue.Count() > 0)
                {
                    var t = queue.Dequeue();
                    Console.WriteLine(t);
                    if (dict.ContainsKey(t))
                    {
                        foreach (var item in dict[t])
                        {
                            if (!rec.Contains(item))
                            {
                                rec.Add(item);
                                queue.Enqueue(item);
                            }
                        }
                    }
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

            graph.Bfs(4);
        }
    }
}
