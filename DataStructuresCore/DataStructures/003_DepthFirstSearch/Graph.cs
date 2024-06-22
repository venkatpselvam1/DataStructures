namespace _003_DepthFirstSearch;

public class Graph
{
    bool[] rec;
    int[,] graph;
    public Graph(int n)
    {
        this.graph = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            this.graph[i, i] = 1;
        }
        this.rec = new bool[n];
    }
    public void AddEdge(int a, int b)
    {
        graph[a, b] = 1;
        graph[b, a] = 1;
    }
    public void DeleteEdge(int a, int b)
    {
        graph[a, b] = 0;
        graph[b, a] = 0;
    }

    public void Print()
    {
        for (int i = 0; i < graph.GetLength(0); i++)
        {
            for (int j = 0; j < graph.GetLength(1); j++)
            {
                Console.Write(graph[i, j] + ", ");
            }

            Console.WriteLine();
        }
    }
    public void Dfs(int n)
    {
        rec[n] = true;
        Console.WriteLine(n);
        for(int i = 0; i < graph.GetLength(0); i++)
        {
            if (graph[n, i] == 1 && !rec[i])
            {
                rec[i] = true;
                Dfs(i);
            }
        }
    }
}