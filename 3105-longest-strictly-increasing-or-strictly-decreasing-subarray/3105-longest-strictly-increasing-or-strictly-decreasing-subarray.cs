public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int increase = 1, decrease = 1, result = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > nums[i - 1]) { decrease = 1; increase++; }
            else if (nums[i] < nums[i - 1]) { increase = 1; decrease++; }
            else { increase = 1; decrease = 1; }

            result = Math.Max(result, Math.Max(increase, decrease));
        }

        return result;
    }
}