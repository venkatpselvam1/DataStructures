namespace _002_AdjacencyMatrix_Graph;

public class Graph
{
    int[,] graph;
    public Graph(int n)
    {
        this.graph = new int[n, n];
        for(int i = 0; i < n; i++)
        {
            this.graph[i, i] = 1;
        }
    }
    public void AddEdge(int a, int b)
    {
        graph[a, b] = 1;
        graph[b, a] = 1;
    }
    public void DeleteEdge(int a , int b)
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
                Console.Write(graph[i, j]+", ");
            }

            Console.WriteLine();
        }
    }
}