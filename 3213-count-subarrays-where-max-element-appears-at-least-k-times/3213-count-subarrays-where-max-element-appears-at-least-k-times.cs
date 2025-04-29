public class Solution {
    public long CountSubarrays(int[] nums, int k) {
        int max = int.MinValue, count = 0, left = 0;
        long result = 0;

        foreach (var num in nums) max = Math.Max(max, num);

        for (int right = 0; right < nums.Length; right++) {
            if (nums[right] == max) count++;

            while (count == k) {
                if (nums[left] == max) count--;
                left++;
            }

            result += left;
        }

        return result;
    }
}