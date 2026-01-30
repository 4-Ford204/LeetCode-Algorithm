public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int consecutive = 0, result = int.MinValue;

        for (int i = 0; i < nums.Length; i++) {
            consecutive = nums[i] == 1 ? consecutive + 1 : 0;
            result = Math.Max(result, consecutive);
        }

        return result;
    }
}