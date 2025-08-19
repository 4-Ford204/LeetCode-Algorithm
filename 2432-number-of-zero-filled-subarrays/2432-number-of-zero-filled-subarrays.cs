public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        long streak = 0, result = 0;

        for (int i = 0; i < nums.Length; i++) {
            streak = nums[i] == 0 ? streak + 1 : 0;
            result += streak;
        }

        return result;
    }
}