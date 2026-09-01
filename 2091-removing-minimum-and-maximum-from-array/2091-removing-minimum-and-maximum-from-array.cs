public class Solution {
    public int MinimumDeletions(int[] nums) {
        int n = nums.Length, min = 0, max = 0;

        for (int i = 0; i < n; i++) {
            if (nums[i] < nums[min]) min = i;
            if (nums[i] > nums[max]) max = i;
        }

        int L = Math.Min(min, max), R = Math.Max(min, max);
        
        return Math.Min(Math.Min(R + 1, n - L),L + 1 + n - R);
    }
}