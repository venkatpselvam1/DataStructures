using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ConcatenatedWords_DP
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
        public class Solution
        {
            public class Trie
            {
                public Dictionary<char, Trie> dict = new Dictionary<char, Trie>();
                public bool isWord;
                public void AddWord(string s, int ind)
                {
                    if (ind == s.Length)
                    {
                        isWord = true;
                        return;
                    }
                    var ch = s[ind];
                    if (!dict.ContainsKey(ch))
                    {
                        dict.Add(ch, new Trie());
                    }

                    dict[ch].AddWord(s, ind + 1);
                }
            }
            IList<string> ans = new List<string>();
            Trie root = new Trie();
            bool?[] dp;
            public IList<string> FindAllConcatenatedWordsInADict(string[] words)
            {
                foreach (var word in words)
                {
                    root.AddWord(word, 0);
                }

                foreach (var word in words)
                {
                    dp = new bool?[word.Length];
                    if (Dfs(root, word, 0))
                    {
                        ans.Add(word);
                    }
                }
                return ans;
            }
            public bool Dfs(Trie node, string word, int ind, bool isFirstWordFound = false)
            {
                if (word.Length == ind)
                {
                    return false;
                }
                var ch = word[ind];
                if (node.dict.ContainsKey(ch))
                {
                    var newNode = node.dict[ch];
                    if (newNode.isWord)
                    {
                        if (ind == word.Length - 1)
                        {
                            return isFirstWordFound;
                        }
                        if (dp[ind+1].HasValue)
                        {
                            if (dp[ind+1].Value)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (Dfs(root, word, ind + 1, true))
                            {
                                dp[ind] = true;
                                return true;
                            }
                            else
                            {
                                dp[ind] = false;
                            }
                        }
                    }
                    if (ind == word.Length - 1)
                    {
                        return false;
                    }
                    return Dfs(newNode, word, ind + 1, isFirstWordFound);
                }
                return false;
            }
        }
    }
}
