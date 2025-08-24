public class Solution {
    public int LongestSubarray(int[] nums) {
        int previous = 0, current = 0, result = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                previous = current;
                current = i + 1;
            }

            result = Math.Max(result, i - previous);
        }

        return result;
    }
}