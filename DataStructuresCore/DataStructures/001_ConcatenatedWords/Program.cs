// See https://aka.ms/new-console-template for more information

using _001_ConcatenatedWords;

var sln = new Solution();
var words = new string[] { "cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat"};
var ans = sln.FindAllConcatenatedWordsInADict(words);
foreach (var item in ans)
{
    Console.Write(item+", ");
}
Console.WriteLine();