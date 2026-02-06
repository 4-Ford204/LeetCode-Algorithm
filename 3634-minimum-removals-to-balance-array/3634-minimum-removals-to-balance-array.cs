public class Solution {
    public int MinRemoval(int[] nums, int k) {
        Array.Sort(nums);
        int n = nums.Length, j = 0, result = n;

        for (int i = 0; i < n; i++) {
            while (j < n && nums[j] <= (long)nums[i] * k) j++;
            result = Math.Min(result, n - (j - i));
        }

        return result;
    }
}