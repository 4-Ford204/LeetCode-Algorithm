public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        return DP(nums, target);
    }

    private int BruteForceRecursion(int[] nums, int target, int total, int index) {
        if (index == nums.Length) return total == target ? 1 : 0;
        else {
            int result = 0;
            result += BruteForceRecursion(nums, target, total + nums[index], index + 1);
            result += BruteForceRecursion(nums, target, total - nums[index], index + 1);

            return result;
        }
    }

    private int DP(int[] nums, int target) {
        int maxTotal = nums.Sum();
        int[,] dp = new int[nums.Length, 2 * maxTotal + 1];
        dp[0, maxTotal + nums[0]] += 1;
        dp[0, maxTotal - nums[0]] += 1;

        for (int i = 1; i < nums.Length; i++) {
            for (int bonus = -maxTotal; bonus <= maxTotal; bonus++) {
                if (dp[i - 1, maxTotal + bonus] > 0) {
                    dp[i, maxTotal + bonus + nums[i]] += dp[i - 1, maxTotal + bonus];
                    dp[i, maxTotal + bonus - nums[i]] += dp[i - 1, maxTotal + bonus];
                }
            }
        }

        return Math.Abs(target) > maxTotal ? 0 : dp[nums.Length - 1, maxTotal + target];
    }
}