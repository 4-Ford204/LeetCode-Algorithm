public class Solution {
    public int XorAfterQueries(int[] nums, int[][] queries) {
        int modulo = 1_000_000_007;
        int n = nums.Length, q = queries.Length, result = 0;

        for (int i = 0; i < q; i++) {
            var current = queries[i];
            int l = current[0];
            int r = current[1];
            int k = current[2];
            long v = current[3];

            for (int j = l; j <= r; j += k) {
                var updated = (nums[j] * v) % modulo;
                nums[j] = (int)updated;
            }
        }

        for (int i = 0; i < n; i++) result ^= nums[i];

        return result;
    }
}