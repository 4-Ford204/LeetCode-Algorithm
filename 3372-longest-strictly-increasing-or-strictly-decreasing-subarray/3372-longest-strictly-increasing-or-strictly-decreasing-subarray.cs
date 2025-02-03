public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int longest = 1, increasing = 1, decreasing = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i - 1] < nums[i]) {
                increasing++;
                decreasing = 1;
            } else if (nums[i - 1] > nums[i]) {
                decreasing++;
                increasing = 1;
            } else {
                increasing = 1;
                decreasing = 1;
            }

            longest = Math.Max(longest, Math.Max(increasing, decreasing));
        }

        return longest;
    }
}