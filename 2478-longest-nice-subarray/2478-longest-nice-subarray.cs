public class Solution {
    public int LongestNiceSubarray(int[] nums) {
        int left = 0, right, bitmask = 0, result = 0;

        for (right = 0; right < nums.Length; right++) {
            while ((bitmask & nums[right]) != 0)
                bitmask ^= nums[left++];

            bitmask |= nums[right];
            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}