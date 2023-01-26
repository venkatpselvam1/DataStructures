using _001_TestCases;
using DotNetty.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Graph_DFS_With_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();

            IGraphTestCase testCase = new TestCaseHard();
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var ans = sln.FindCheapestPrice(testCase.GetN(), testCase.GetFlights(), testCase.GetSrc(), testCase.GetDst(), testCase.GetK());
            stopwatch.Stop();
            Console.WriteLine("ans : "+ans+" and expected "+testCase.GetAns());
            Console.WriteLine("time taken : "+stopwatch.Elapsed);
        }
    }
    public class Solution
    {
        int dst, k;
        int[][] dp;
        List<int[]>[] edges;
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            this.k = k;
            this.dst = dst;
            edges = new List<int[]>[n];
            this.dp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                this.dp[i] = new int[k + 1];
                this.edges[i] = new List<int[]>();
            }
            var l1 = flights.GetLength(0);
            for( int i = 0; i < l1; i++)
            {
                this.edges[flights[i][0]].Add(flights[i]);
            }
            return Dfs(src, 0, 0);
        }
        private int Dfs(int ind, int cost, int stops)
        {
            Console.WriteLine("ind "+ind+" cost"+cost+" stop "+ stops);
            if(ind == dst)
            {
                return cost;
            }
            if(stops > k)
            {
                return -1;
            }
            if (dp[ind][stops] == cost && cost != 0)
            {
                return dp[ind][stops];
            }
            for(int s = 0; s <= stops; s++)
            {
                if (dp[ind][s] > 0 && dp[ind][s] < cost) return -1;
            }
            var ans = -1;
            foreach(var item in this.edges[ind])
            {
                var temp = Dfs(item[1], cost + item[2], stops + 1);
                if(temp != -1)
                {
                    if(ans == -1 || ans > temp)
                    {
                        ans = temp;
                    }
                }
            }
            if (ans != -1) dp[ind][stops] = ans;
            return ans;
        }
    }
}
