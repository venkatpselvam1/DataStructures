namespace _002_Graph_DFS_With_DP;

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