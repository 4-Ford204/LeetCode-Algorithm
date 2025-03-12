public class Solution {
    public int MaximumCount(int[] nums) {
        int n = nums.Length, i = 0, j = n;

        if (nums[0] > 0 || nums[n - 1] < 0) return n;

        for (i = 0; i < n; i++) {
            if (nums[i] >= 0) {
                j = i--;
                while (j < n && nums[j] == 0) j++;
                break;
            }
        }

        return Math.Max(i + 1, n - j);
    }
}