public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int prefix = 0;
        int start = 0;
        int result = int.MaxValue;

        for (int i = 0; i < nums.Length; i++) {
            prefix += nums[i];

            while (prefix >= target) {
                result = Math.Min(result, i - start + 1);
                prefix -= nums[start++];
            }
        }

        return result == int.MaxValue ? 0 : result;
    }
}