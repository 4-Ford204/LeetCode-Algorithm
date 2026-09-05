public class Solution {
    public int FirstStableIndex(int[] nums, int k) {
        int n = nums.Length;
        int min = int.MaxValue, max = int.MinValue;
        int[] prefix = new int[n];

        for (int i = n - 1; i >= 0; i--) {
            min = Math.Min(min, nums[i]);
            prefix[i] = min;
        }

        for (int i = 0; i < n; i++) {
            max = Math.Max(max, nums[i]);
            if (max - prefix[i] <= k) return i;
        }

        return -1;
    }
}