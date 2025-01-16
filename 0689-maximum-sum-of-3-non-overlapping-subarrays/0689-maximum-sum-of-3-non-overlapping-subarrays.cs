public class Solution {
    public int[] MaxSumOfThreeSubarrays(int[] nums, int k) {
        int n = nums.Length, endIndex = n;
        int[] prefix = new int[n + 1], result = new int[3];
        int[,] sums = new int[4, n + 1], indexes = new int[4, n + 1];

        for (int i = 1; i <= n; i++) prefix[i] = prefix[i - 1] + nums[i - 1];

        for (int i = 1; i <= 3; i++) {
            for (int end = k * i; end <= n; end++) {
                int sum = prefix[end] - prefix[end - k] + sums[i - 1, end - k];

                if (sum > sums[i, end - 1]) {
                    sums[i, end] = sum;
                    indexes[i, end] = end - k;
                } else {
                    sums[i, end] = sums[i, end - 1];
                    indexes[i, end] = indexes[i, end - 1];
                }
            }
        }

        for (int i = 3; i >= 1; i--) {
            result[i - 1] = indexes[i, endIndex];
            endIndex = result[i - 1];
        }

        return result;
    }
}
