public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');
        var map = new Dictionary<char, string>();
        var hashset = new HashSet<string>();

        if (pattern.Length != words.Length) return false;

        for (int i = 0; i < pattern.Length; i++) {
            if (map.TryGetValue(pattern[i], out string value)) {
                if (!words[i].Equals(value)) return false;
            }
            else if (hashset.Contains(words[i])) return false;
            else {
                map[pattern[i]] = words[i];
                hashset.Add(words[i]);
            }
        }

        return true;
    }
}