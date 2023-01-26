using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_DepthFirstSearch_AdjacencyList
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
                if (dict.ContainsKey(a))
                {
                    dict[a].Add(b);
                }
                else
                {
                    dict.Add(a, new List<int>() { b });
                }
            }
            public void Dfs(int n)
            {
                rec.Add(n);
                DfsRec(n);
            }
            private void DfsRec(int n)
            {
                Console.WriteLine(n);
                if (dict.ContainsKey(n))
                {
                    foreach (var item in dict[n])
                    {
                        if (!rec.Contains(item))
                        {
                            rec.Add(item);
                            DfsRec(item);
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
            Console.WriteLine("DFS for 3");
            graph.Dfs(3);
        }
    }
}
