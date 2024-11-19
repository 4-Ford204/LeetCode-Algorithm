public class Solution {
    public int DeleteAndEarn(int[] nums) {
        if (nums.Length == 1) return nums[0];

        int maxNum = nums.Max();
        int[] frequency = new int[maxNum + 1];

        for (int i = 0; i < nums.Length; i++) {
            frequency[nums[i]]++;
        }

        int[] dp = new int[maxNum + 1];
        dp[0] = frequency[0];
        dp[1] = frequency[1];
        int max = Math.Max(dp[0], dp[1]);

        for (int i = 2; i <= maxNum; i++) {
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + i * frequency[i]);
            max = Math.Max(dp[i], max);
        }

        return max;
    }
}