public class Solution {
    public int LongestSubarray(int[] nums) {
        int max = 0, current = 0, result = 0;

        foreach (var num in nums) {
            if (num > max) {
                max = num;
                current = result = 0;
            }

            current = num == max ? current + 1 : 0;
            result = Math.Max(result, current);
        }

        return result;
    }
}