public class Solution {
    public bool CanPartition(int[] nums) {
        int total = 0;

        foreach (var num in nums) total += num;

        if (total % 2 != 0) return false;

        int target = total / 2;
        bool[] dp = new bool[target + 1];
        dp[0] = true;

        foreach (var num in nums) {
            for (int i = target; i >= num; i--) {
                dp[i] = dp[i] || dp[i - num];
                if (i == target && dp[i]) return true;
            }
        }

        return dp[target];
    }
}