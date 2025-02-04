public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int maxAscendingSum = nums[0], result = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i - 1] < nums[i]) maxAscendingSum += nums[i];
            else maxAscendingSum = nums[i];

            result = Math.Max(result, maxAscendingSum);
        }

        return result;
    }
}