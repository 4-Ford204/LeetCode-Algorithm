public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var dictionary = new Dictionary<char, int>();
        int left = 0, result = 0;

        for (int right = 0; right < s.Length; right++) {
            char current = s[right];

            if (dictionary.ContainsKey(current))
                left = Math.Max(left, dictionary[current]);

            result = Math.Max(result, right - left + 1);
            dictionary[current] = right + 1;
        }
        
        return result;
    }
}