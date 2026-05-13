public class Solution {
    public int MinMoves(int[] nums, int limit) {
        int n = nums.Length, result = int.MaxValue;
        var arr = new int[2 * limit + 2];

        for (int i = 0; i < n / 2; i++) {
            int L = nums[i], R = nums[n - 1 - i];
            arr[Math.Min(L, R) + 1]--;
            arr[L + R]--;
            arr[L + R + 1]++;
            arr[Math.Max(L, R) + limit + 1]++;
        }

        for (int i = 2; i <= 2 * limit; i++) {
            n += arr[i];
            result = Math.Min(result, n);
        }

        return result;
    }
}