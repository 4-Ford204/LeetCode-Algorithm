public class Solution {
    public int MinScoreTriangulation(int[] values) {
        int n = values.Length;
        int[][] dp = new int[n][];

        for (int i = 0; i < n; i++) dp[i]= new int[n];

        for (int j = 2; j < n; j++) {
            for (int i = j - 2; i >= 0; i--) {
                dp[i][j] = int.MaxValue;

                for (int k = i + 1; k < j; k++) {
                    dp[i][j] = Math.Min(
                        dp[i][j],
                        dp[i][k] + dp[k][j] + values[i] * values[k] * values[j]    
                    );
                }
            }
        }

        return dp[0][n - 1];
    }
}