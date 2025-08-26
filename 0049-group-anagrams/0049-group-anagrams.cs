public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var group = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var freq = new char[26];
            foreach (var character in str) freq[character - 'a']++;

            var word = new string(freq);
            if (!group.ContainsKey(word)) group[word] = new List<string>();
            group[word].Add(str);
        }

        return new List<IList<string>>(group.Values);
    }
}