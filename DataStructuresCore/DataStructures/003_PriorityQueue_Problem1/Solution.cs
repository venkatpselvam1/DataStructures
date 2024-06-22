namespace _003_PriorityQueue_Problem1;

    public class Solution
    {
        int h, w;
        bool[,] rec;
        int[,] dirs = new int[4, 2]
        {
        {1, 0},
        {0,1},
        {0,-1},
        {-1, 0}
        };
        SortedList<int, List<Node>> sort;
        public int TrapRainWater(int[][] grid)
        {
            var ans = 0;
            sort = new SortedList<int, List<Node>>();
            h = grid.Length;
            w = grid[0].Length;
            this.rec = new bool[h, w];
            for (int i = 0; i < h; i++)
            {
                Add(new Node(i, 0, grid[i][0]));
                Add(new Node(i, w - 1, grid[i][w - 1]));
                rec[i, 0] = true;
                rec[i, w - 1] = true;
            }
            for (int j = 0; j < w; j++)
            {
                //sort.Add(grid[0][j] , new Node(){ x = 0, y = j, val = grid[0][j]});
                //sort.Add(grid[h-1][j] , new Node(){ x = h-1, y = j, val = grid[h-1][j] });   
                Add(new Node(0, j, grid[0][j]));
                Add(new Node(h - 1, j, grid[h - 1][j]));
                rec[0, j] = true;
                rec[h - 1, j] = true;
            }
            var d = sort.First().Value.First().val;
            while (sort.Count() > 0)
            {
                var n = sort.First().Value.First();
                Remove(n);
                if (d - n.val > 0)
                {
                    ans += d - n.val;
                }
                d = Math.Max(d, n.val);
                for (int k = 0; k < 4; k++)
                {
                    var ni = n.x + dirs[k, 0];
                    var nj = n.y + dirs[k, 1];
                    if (IsValid(ni, nj) && !rec[ni, nj])
                    {
                        rec[ni, nj] = true;
                        Add(new Node(ni, nj, grid[ni][nj]));
                    }
                }
            }
            return ans;
        }
        public void Add(Node n)
        {
            if (sort.ContainsKey(n.val))
            {
                sort[n.val].Add(n);
            }
            else
            {
                sort.Add(n.val, new List<Node>() { n });
            }
        }
        public void Remove(Node n)
        {
            if (sort.ContainsKey(n.val))
            {
                if (sort[n.val].Count() == 1)
                {
                    sort.Remove(n.val);
                }
                else
                {
                    sort[n.val].Remove(n);
                }
            }
        }
        public bool IsValid(int a, int b)
        {
            return a >= 0 && b >= 0 && a < h && b < w;
        }
        public class Node
        {
            public Node(int a, int b, int c)
            {
                x = a;
                y = b;
                val = c;
            }
            public int x;
            public int y;
            public int val;
        }
    }