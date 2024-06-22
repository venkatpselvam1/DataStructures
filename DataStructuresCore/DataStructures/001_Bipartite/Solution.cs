namespace _001_Bipartite;

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