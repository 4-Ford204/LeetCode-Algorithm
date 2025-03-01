public class Solution {
    public int[] ApplyOperations(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];

        for (int i = 0; i < n - 1; i++) {
            if (nums[i] == nums[i + 1]) {
                nums[i++] *= 2;
                nums[i] = 0;
            }
        }

        for (int i = 0, j = 0; i < n; i++) {
            if (nums[i] != 0) result[j++] = nums[i];
        }

        return result;
    }
}