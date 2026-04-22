public class TrieNode {
    public Dictionary<char, TrieNode> Chars = new Dictionary<char, TrieNode>();
    public bool IsLast = false;
}

public class Solution {
    private TrieNode root = new TrieNode();

    public IList<string> TwoEditWords(string[] queries, string[] dictionary) {
        var result = new List<string>();

        foreach (var query in queries) {
            foreach (var word in dictionary) {
                int changes = 0;

                for (int i = 0; i < query.Length && changes <= 2; i++) {
                    if (query[i] != word[i]) changes++;
                }

                if (changes <= 2) {
                    result.Add(query);
                    break;
                }
            }
        }

        return result;
    }

    private IList<string> Trie(string[] queries, string[] dictionary) {
        var result = new List<string>();

        foreach (var word in dictionary) {
            var current = root;

            for (int i = 0; i < word.Length; i++) {
                current.Chars.TryAdd(word[i], new TrieNode());
                current = current.Chars[word[i]];
            }

            current.IsLast = true;
        }

        foreach (var word in queries) {
            if (Search(word, root, 0, 2)) result.Add(word);
        }

        return result;
    }

    private bool Search(string word, TrieNode current, int index, int changes) {
        var node = current;

        for (int i = index; i < word.Length; i++) {
            if (changes > 0) {
                foreach (var character in node.Chars) {
                    if (Search(word, character.Value, i + 1, changes - 1)) return true;
                }
            }

            if (node.Chars.ContainsKey(word[i])) node = node.Chars[word[i]];
        }

        return node.IsLast;
    }
}