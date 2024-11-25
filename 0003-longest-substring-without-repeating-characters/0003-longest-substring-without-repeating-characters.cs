public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> substring = new Dictionary<char, int>();
        int start = 0;
        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            if (!substring.TryGetValue(s[i], out var index))
                substring.Add(s[i], i);
            else {
                if (index == -1) substring[s[i]] = i;
                else {
                    for (int j = start; j < index; j++) 
                        substring[s[j]] = -1;

                    start = index + 1;
                    substring[s[i]] = i;
                }
            }
            
            result = Math.Max(result, i - start + 1);
        }

        return result;
    }
}