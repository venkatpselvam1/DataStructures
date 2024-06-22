namespace _002_BreathFirstSearch_WithAdjacencyList;

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
        Console.WriteLine("BFS for n");
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