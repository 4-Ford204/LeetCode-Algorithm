public class Solution {
    public long CountSubarrays(int[] nums, long k) {
        int n = nums.Length, left = 0, size = 0;
        long prefix = 0, result = 0;

        for (int right = 0; right < n; right++) {
            prefix += nums[right];
            size += 1;

            while (size > 0 && prefix * size >= k) {
                prefix -= nums[left];
                left++;
                size--;
            }

            result += size;
        }

        return result;
    }
}