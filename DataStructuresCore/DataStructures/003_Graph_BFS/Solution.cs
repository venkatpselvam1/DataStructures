namespace _003_Graph_BFS;

public class Solution
{
    List<int[]>[] edges;
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        Console.WriteLine(n+" "+src+" "+dst+" "+k);
        this.edges = new List<int[]>[n];
        int[] dist = new int[n];
        for (int i = 0; i < n; i++)
        {
            dist[i] = Int32.MaxValue;
            this.edges[i] = new List<int[]>();
        }
        foreach (var flight in flights)
        {
            edges[flight[0]].Add(flight);
        }
                
        var q = new Queue<int[]>();//array contains ind, cost
        q.Enqueue(new int[] {src, 0});
        var curr = 0;
        while(curr <= k && q.Any())
        {
            var q2 = new Queue<int[]>();//array contains ind, cost
            while (q.Any())
            {
                var node = q.Dequeue();
                foreach(var item in edges[node[0]])
                {
                    var newDist = item[2] + node[1];
                    if (dist[item[1]] < newDist) continue;
                    dist[item[1]] = newDist;
                    if (item[1] == dst) continue;
                    q2.Enqueue(new int[] { item[1], newDist });
                            
                }
            }
            q = q2;
            curr++;
        }
        return dist[dst] == Int32.MaxValue ? -1 : dist[dst];
    }
}