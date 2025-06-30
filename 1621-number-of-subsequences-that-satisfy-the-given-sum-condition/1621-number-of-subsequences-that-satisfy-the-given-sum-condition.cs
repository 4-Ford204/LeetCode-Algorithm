public class Solution {
    public int NumSubseq(int[] nums, int target) {
        int n = nums.Length, result = 0, mod = 1_000_000_007;
        int left = 0, right = n - 1;
        int[] dp = new int[n];

        Array.Sort(nums);
        dp[0] = 1;

        for (int i = 1; i < n; i++)
            dp[i] = (dp[i - 1] * 2) % mod;

        while (left <= right) {
            if (nums[left] + nums[right] > target) right--;
            else result = (result + dp[right - left++]) % mod;
        }

        return result;
    }
}