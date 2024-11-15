public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        TrieNode root = new TrieNode();
        TrieNode node;
        List<IList<string>> result = new List<IList<string>>();
        Array.Sort(products);

        foreach (var product in products) {
            node = root;

            foreach (var i in product) {
                node = node.Nodes[i - 'a'] ??= new TrieNode();
                node.Words.Add(product);
            }
        }

        node = root;
        foreach (var i in searchWord) {
            node = node?.Nodes[i - 'a'];
            result.Add(node == null ? Array.Empty<string>() : node.Words.Take(3).ToList());
        }

        return result;
    }
}

public class TrieNode {
    public TrieNode[] Nodes { get; set; } = new TrieNode[26];
    public HashSet<string> Words { get; set; } = new HashSet<string>();
}