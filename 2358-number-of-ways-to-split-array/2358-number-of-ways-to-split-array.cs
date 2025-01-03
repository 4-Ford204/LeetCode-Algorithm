public class Solution {
    public int WaysToSplitArray(int[] nums) {
        int result = 0;
        long prefix = 0, suffix = 0;

        for (int i = 0; i < nums.Length; i++) suffix += nums[i];

        for (int i = 0; i < nums.Length - 1; i++) {
            prefix += nums[i];
            suffix -= nums[i];

            if (prefix >= suffix) result++;
        }

        return result;
    }
}