namespace _004_DepthFirstSearch_AdjacencyList;

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