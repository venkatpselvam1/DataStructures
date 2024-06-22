// See https://aka.ms/new-console-template for more information

using _001_SegmentTree;

var sln = new Solution();
var arr = new int[] { 4, 2, 1, 4, 3, 4, 5, 8, 15 };
var ans = sln.LengthOfLIS(arr, 3);
System.Console.WriteLine("ans " + ans);


SegmentTreeTest.TestSegmentTree();
