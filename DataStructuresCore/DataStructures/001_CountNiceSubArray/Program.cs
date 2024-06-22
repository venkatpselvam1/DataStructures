// See https://aka.ms/new-console-template for more information

//https://leetcode.com/problems/count-number-of-nice-subarrays/description

using _001_CountNiceSubArray;

var sln = new Solution();
var nums = new int[]{1,1,2,1,1};
var k = 3;
var expected = 2;
var actual = sln.NumberOfSubarrays(nums, k);
Console.WriteLine($"Expected vs Actual = {expected}  vs {actual}");
