public class Solution {
    public long MaxSubarraySum(int[] nums, int k) {
        long prefix = 0, result = long.MinValue;
        var remainder = new long[k];

        Array.Fill(remainder, long.MaxValue / 2);
        remainder[^1] = 0;

        for (int i = 0; i < nums.Length; i++) {
            prefix += nums[i];
            result = Math.Max(result, prefix - remainder[i % k]);
            remainder[i % k] = Math.Min(remainder[i % k], prefix);
        }

        return result;
    }
}