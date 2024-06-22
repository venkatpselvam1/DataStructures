namespace _003_AdjacencyList_Graph;

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