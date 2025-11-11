public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {
        int[][] dp = new int[m + 1][];

        for (int i = 0; i <= m; i++) dp[i] = new int[n + 1];

        foreach (var str in strs) {
            int zero = 0, one = 0;

            foreach (char character in str) {
                if (character == '1') one++;
                else zero++;
            }

            for (int i = m; i >= zero; i--) {
                for (int j = n; j >= one; j--) {
                    dp[i][j] = Math.Max(
                        dp[i][j],
                        dp[i - zero][j - one] + 1
                    );
                }
            }
        }

        return dp[m][n];
    }
}