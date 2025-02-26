public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
        int prefix = 0, minPrefix = 0, maxPrefix = 0;

        for (int i = 0; i < nums.Length; i++) {
            prefix += nums[i];
            minPrefix = Math.Min(minPrefix, prefix);
            maxPrefix = Math.Max(maxPrefix, prefix);
        }

        return maxPrefix - minPrefix;
    }
}