// See https://aka.ms/new-console-template for more information

// TODO: OLD - as dotnet don't have built-in priority queue we can use the sorted list.
// TODO: Dotnet Framework don't have built-in priority queue but dotnet core have. So use dotnet core and rewrite this
using _003_PriorityQueue_Problem1;

var sln = new Solution();
int[][] grid = new int[][]
{
    new int[]{3,3,3,3,3},
    new int[]{3,2,2,2,3},
    new int[]{3,2,1,2,3},
    new int[]{3,2,2,2,3},
    new int[]{3,3,3,3,3}
};
var ans = sln.TrapRainWater(grid);
Console.WriteLine(ans);