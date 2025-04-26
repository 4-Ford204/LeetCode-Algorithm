public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK) {
        int left = -1, minL = -1, maxL = -1;
        long result = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] >= minK && nums[i] <= maxK) {
                minL = (nums[i] == minK) ? i : minL;
                maxL = (nums[i] == maxK) ? i : maxL;
                result += Math.Max(0, Math.Min(minL, maxL) - left);
            } else {
                left = i;
                minL = -1;
                maxL = -1;
            }
        }

        return result;
    }
}