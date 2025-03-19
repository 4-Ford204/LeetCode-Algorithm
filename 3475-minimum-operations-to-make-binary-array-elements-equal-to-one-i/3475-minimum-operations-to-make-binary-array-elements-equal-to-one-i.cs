public class Solution {
    public int MinOperations(int[] nums) {
        int n = nums.Length, result = 0;

        for (int i = 0; i < n - 2; i++) {
            if (nums[i] == 0) {
                nums[i] = 1;
                nums[i + 1] = 1 - nums[i + 1];
                nums[i + 2] = 1 - nums[i + 2];
                result++;
            }
        }

        return (nums[n - 1] == 0 || nums[n - 2] == 0) ? -1 : result;
    }
}