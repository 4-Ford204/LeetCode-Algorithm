public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
        int n = nums.Length;
        int result = Math.Abs(nums[0] - nums[n - 1]);

        for (int i = 0; i < n - 1;)
            result = Math.Max(result, Math.Abs(nums[i] - nums[++i]));

        return result;
    }
}