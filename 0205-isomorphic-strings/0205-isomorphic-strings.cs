public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;

        var map = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++) {
            if (map.TryGetValue(s[i], out var value)) {
                if (t[i] != value) return false;
            }
            else if (map.ContainsValue(t[i])) return false;
            else map[s[i]] = t[i];
        }
 
        return true;
    }
}