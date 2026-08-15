public class Solution {
    public int LongestSubsequence(int[] nums) {
        int n = nums.Length, xor = 0;
        var zero = true;

        foreach (var num in nums) {
            xor ^= num;
            if (xor > 0) zero = false;
        }

        return xor > 0 ? n : zero ? 0 : n - 1;
    }
}