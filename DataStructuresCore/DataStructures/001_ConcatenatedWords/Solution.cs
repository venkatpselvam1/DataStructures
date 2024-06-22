namespace _001_ConcatenatedWords;

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

                    dict[ch].AddWord(s, ind+1);
                }
            }
            IList<string> ans = new List<string>();
            Trie root = new Trie();
            public IList<string> FindAllConcatenatedWordsInADict(string[] words)
            {
                foreach (var word in words)
                {
                    root.AddWord(word, 0);
                }

                foreach (var word in words)
                {
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
                        if (ind == word.Length -1)
                        {
                            return isFirstWordFound;
                        }
                        if (Dfs(root, word, ind+1, true))
                        {
                            return true;
                        }
                    }
                    if (ind == word.Length - 1)
                    {
                        return false;
                    }
                    return Dfs(newNode, word, ind+1, isFirstWordFound);
                }
                return false;
            }
        }