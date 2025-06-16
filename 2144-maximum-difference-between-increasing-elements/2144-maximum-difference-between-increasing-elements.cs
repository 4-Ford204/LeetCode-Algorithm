public class Solution {
    public int MaximumDifference(int[] nums) {
        int result = -1, preMin = nums[0];

        foreach (var num in nums) {
            if (num > preMin)
                result = Math.Max(result, num - preMin);
            else
                preMin = num;
        }

        return result;
    }
}