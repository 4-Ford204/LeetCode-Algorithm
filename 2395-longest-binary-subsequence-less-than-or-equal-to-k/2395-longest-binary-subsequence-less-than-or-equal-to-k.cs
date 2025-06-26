public class Solution {
    public int LongestSubsequence(string s, int k) {
        int n = s.Length, dp = 0, result = 0;
        int maxBit = (int)Math.Log(k, 2);

        for (int i = 0; i < n; i++) {
            var bit = s[n - 1 - i];

            if (bit == '1') {
                if (i <= maxBit && dp + (1 << i) <= k) {
                    dp += 1 << i;
                    result++;
                }
            } else result++;
        }

        return result;
    }
}