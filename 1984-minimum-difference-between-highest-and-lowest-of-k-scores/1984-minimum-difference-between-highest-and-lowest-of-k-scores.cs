public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        Array.Sort(nums);
        int n = nums.Length, result = int.MaxValue;

        for (int i = k - 1; i < n; i++) result = Math.Min(result, nums[i] - nums[i - k + 1]);
        
        return result;
    }
}