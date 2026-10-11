public class Solution {
    public int SumOfSquares(int[] nums) {
        int n = nums.Length, result = 0;

        for (int i = 0; i < n; i++) {
            if (n % (i + 1) == 0) result += nums[i] * nums[i];
        }

        return result;
    }
}