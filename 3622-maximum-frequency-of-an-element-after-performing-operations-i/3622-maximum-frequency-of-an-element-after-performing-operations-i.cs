public class Solution {
    public int MaxFrequency(int[] nums, int k, int numOperations) {
        int min = int.MaxValue, n = nums.Max() + k + 2;
        int[] count = new int[n];
        int prefix = 0, result = 0; 

        foreach (var num in nums) {
            min = Math.Min(min, num);
            count[num]++;
        }

        for (int i = min; i < n; i++) {
            prefix += count[i];

            if (i >= k) {
                result = Math.Max(
                    result,
                    count[i - k] + Math.Min(prefix - count[i - k], numOperations)
                );

                if (i - 2 * k > -1) prefix -= count[i - 2 * k];
            }
        }

        return result;
    }
}