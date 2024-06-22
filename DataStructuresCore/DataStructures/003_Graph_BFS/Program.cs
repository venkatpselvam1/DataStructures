// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using _001_TestCases;
using _003_Graph_BFS;

var sln = new Solution();
Console.WriteLine("BFS");
IGraphTestCase testCase = new TestCaseHard();
var stopwatch = new Stopwatch();
stopwatch.Start();
var ans = sln.FindCheapestPrice(testCase.GetN(), testCase.GetFlights(), testCase.GetSrc(), testCase.GetDst(), testCase.GetK());
stopwatch.Stop();
Console.WriteLine("ans : " + ans + " and expected " + testCase.GetAns());
Console.WriteLine("time taken : " + stopwatch.Elapsed);