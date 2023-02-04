using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Bipartite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://leetcode.com/problems/is-graph-bipartite/description/
            var sln = new Solution();
            //expected ans for g is false
            var g = new int[][] { 
                new int[]{ 1, 2, 3 },
                new int[] { 0, 2 },
                new int[] { 0, 1, 3 },
                new int[] { 0, 2 }
            };
            //expected ans for g2 is true

            var g2 = new int[][] {
                new int[] { 1, 3 },
                new int[] { 0, 2 },
                new int[] { 1, 3 },
                new int[] { 0, 2 } };
            var ans = sln.IsBipartite(g);
            Console.WriteLine(ans);
        }
        public class Solution
        {
            int[][] graph;
            int n;
            int[] colors;
            public bool IsBipartite(int[][] graph)
            {
                this.graph = graph;
                this.n = graph.Length;
                this.colors = new int[n];
                for(int i= 0; i < n; i++)
                {
                    if (colors[i] == 0 && !dfs(i, 1)) return false;
                }
                return true;
            }
            private bool dfs(int ind, int color)
            {
                colors[ind] = color;
                foreach(var item in graph[ind])
                {
                    if (colors[item] == -color) continue;
                    if (colors[item] == color || !dfs(item, -color)) return false;
                }
                return true;
            }
        }
    }
}
