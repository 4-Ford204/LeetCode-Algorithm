public class Solution {
    public int MaximumLengthSubstring(string s) {
        var map = new int[26];
        int start = 0, result = 0;

        for (int end = 0; end < s.Length; end++) {
            map[s[end] - 'a']++;
            while (map[s[end] - 'a'] > 2) map[s[start++] - 'a']--;
            result = Math.Max(result, end - start + 1);
        }

        return result;
    }
}