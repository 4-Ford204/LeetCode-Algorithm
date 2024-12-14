public class Solution {
    public long ContinuousSubarrays(int[] nums) {
        int left = 0, right = 0, min = nums[right], max = nums[right];
        long windowLength = 0, total = 0;

        for (right = 0; right < nums.Length; right++) {
            min = Math.Min(min, nums[right]);
            max = Math.Max(max, nums[right]);

            if (max - min > 2) {
                windowLength = right - left;
                total += windowLength * (windowLength + 1) / 2;
                left = right;
                min = nums[right];
                max = nums[right];

                while (left > 0 && Math.Abs(nums[right] - nums[left - 1]) <= 2) {
                    left--;
                    min = Math.Min(min, nums[left]);
                    max = Math.Max(max, nums[left]);
                }

                if (left < right) {
                    windowLength = right - left;
                    total -= windowLength * (windowLength + 1) / 2;
                }
            }
        }
        
        windowLength = right - left;
        total += windowLength * (windowLength + 1) / 2;

        return total;
    }
}