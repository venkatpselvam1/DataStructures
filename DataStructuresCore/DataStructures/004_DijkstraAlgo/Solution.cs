namespace _004_DijkstraAlgo;

class Solution
{
    public int findCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        List<int[]>[] list = new List<int[]>[n];
        var dist = new int[n];
        for (int i = 0; i < n; i++)
        {
            list[i] = new List<int[]>();
            dist[i] = int.MaxValue;
        }
        foreach (var flight in flights)
        {
            list[flight[0]].Add(flight);
        }

        //TODO: we need the change this queue to PQ
        var pq = new Queue<int[]>();
        //((a, b)-> {return a[1] - b[1];});

        dist[src] = 0;
        pq.Enqueue(new int[]{src, 0, 0});
        while(pq.Any())
        {
            var node = pq.Dequeue();
            //System.out.println(node[0]+" exploring " + node[1]);
            foreach(var item in  list[node[0]])
            {
                if(node[2]  > k ) continue;
                dist[item[1]] = Math.Min(dist[item[1]], node[1]+item[2]);
                if(item[1] == dst) continue;
                pq.Enqueue(new int[]{ item[1], node[1] +  item[2], node[2] + 1 });
                
            }
        }
        return dist[dst] == int.MaxValue ? -1 : dist[dst];
    }
}