public class Solution {
    public int NumDistinct(string s, string t) {
        int[] dp = new int[t.Length + 1];
        dp[0] = 1;

        for (int i = 1; i <= s.Length; i++) {
            for (int j = t.Length; j >= 1; j--) {
                if (s[i - 1] == t[j - 1]) {
                    dp[j] = dp[j - 1] + dp[j];
                }
            }
        }

        return dp[t.Length];
    }
}