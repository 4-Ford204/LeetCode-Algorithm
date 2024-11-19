public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int length = cost.Length;
        int[] dp = new int[length + 1];

        for (int i = 2; i <= length; i++) {
            dp[i] = Math.Min((cost[i - 1] + dp[i - 1]), (cost[i - 2] + dp[i - 2]));
        }

        return dp[length];
    }
}