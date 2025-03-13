public class Solution {
    public int MinZeroArray(int[] nums, int[][] queries) {
        int n = nums.Length, prefix = 0, k = 0;
        int[] differenceArray = new int[n + 1];

        for (int i = 0; i < n; i++) {
            while (prefix + differenceArray[i] < nums[i]) {
                if (++k > queries.Length) return -1;

                int left = queries[k - 1][0];
                int right = queries[k - 1][1];
                int value = queries[k - 1][2];

                if (right >= i) {
                    differenceArray[Math.Max(left, i)] += value;
                    differenceArray[right + 1] -= value;
                }
            }

            prefix += differenceArray[i];
        }

        return k;
    }
}