public class Solution {
    public int MaxRotateFunction(int[] nums) {
        int n = nums.Length, F = 0, sum = 0;
        int result = int.MinValue;

        for (int i = 0; i < n; i++) {
            F += i * nums[i];
            sum += nums[i];
        }

        for (int i = n - 1; i >= 0; i--) {
            F += sum - n * nums[i];
            result = Math.Max(result, F);
        }

        return result;
    }
}