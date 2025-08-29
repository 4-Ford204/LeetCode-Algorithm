public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var freq = new int[26];

        foreach (var character in s) freq[character - 'a']++;

        foreach (var character in t) freq[character - 'a']--;

        foreach (var value in freq) {
            if (value != 0) return false;
        }

        return true;
    }
}