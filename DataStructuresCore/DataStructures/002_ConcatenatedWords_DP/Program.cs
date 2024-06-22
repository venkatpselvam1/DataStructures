// See https://aka.ms/new-console-template for more information
using _002_ConcatenatedWords_DP;

//even thought the previouse project will solve our problem, we can bring one more improvement over that.
// we can have dp[i] which indicates for the given word if already the given index i present in the root node
var sln = new Solution();
var words = new string[] { "cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat" };
var ans = sln.FindAllConcatenatedWordsInADict(words);
foreach (var item in ans)
{
    Console.Write(item + ", ");
}
Console.WriteLine();