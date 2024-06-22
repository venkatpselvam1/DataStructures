// See https://aka.ms/new-console-template for more information

//https://leetcode.com/problems/is-graph-bipartite/description/

using _001_Bipartite;

var sln = new Solution();
//expected ans for g is false
var g = new int[][] { 
    new int[]{ 1, 2, 3 },
    new int[] { 0, 2 },
    new int[] { 0, 1, 3 },
    new int[] { 0, 2 }
};
//expected ans for g2 is true

var g2 = new int[][] {
    new int[] { 1, 3 },
    new int[] { 0, 2 },
    new int[] { 1, 3 },
    new int[] { 0, 2 } };
var ans = sln.IsBipartite(g);
Console.WriteLine(ans);