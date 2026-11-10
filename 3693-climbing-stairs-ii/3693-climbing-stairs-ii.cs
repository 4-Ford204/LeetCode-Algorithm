public class Solution {
    public int ClimbStairs(int n, int[] costs) {
        var dp = new int[n + 1];

        for (int i = 1; i <= n; i++) {
            dp[i] = int.MaxValue;

            for (int j = 1; j <= 3 && i - j >= 0; j++) 
                dp[i] = Math.Min(
                    dp[i],
                    dp[i - j] + costs[i - 1] + j * j
                );
        }

        return dp[n];
    }
}