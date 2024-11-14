public class Trie {
    public TrieNode TrieNode { get; set; }

    public Trie() {
        TrieNode = new TrieNode();
    }
    
    public void Insert(string word) {
        var node = TrieNode;

        foreach (var i in word) {
            var index = i - 'a';

            if (node.Chars[index] == null)
                node.Chars[index] = new TrieNode();

            node = node.Chars[index];
        }

        node.IsWord = true;
    }
    
    public bool Search(string word) {
        var node = TrieNode;

        foreach (var i in word) {
            var index = i - 'a';

            if (node.Chars[index] == null)
                return false;

            node = node.Chars[index];
        }

        return node.IsWord;
    }
    
    public bool StartsWith(string prefix) {
        var node = TrieNode;

        foreach (var i in prefix) {
            var index = i - 'a';

            if (node.Chars[index] == null)
                return false;

            node = node.Chars[index];
        }

        return true;
    }
}

public class TrieNode {
    public TrieNode[] Chars { get; set; } = new TrieNode[26];
    public bool IsWord { get; set; } = false;
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */