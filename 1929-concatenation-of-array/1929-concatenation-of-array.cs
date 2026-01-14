public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        var result = new int[2 * n];

        for (int i = 0; i < n; i++) {
            var value = nums[i];
            result[i] = value;
            result[i + n] = value;
        }

        return result;
    }
}