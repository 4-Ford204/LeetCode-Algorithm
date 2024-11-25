public class Solution {
    public int LongestSubarray(int[] nums) {
        int tracking = 0;
        int nextTracking = 0;
        int max = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                tracking = nextTracking;
                nextTracking = i + 1;
            }

            max = Math.Max(max, i - tracking);
        }

        return max;
    }
}