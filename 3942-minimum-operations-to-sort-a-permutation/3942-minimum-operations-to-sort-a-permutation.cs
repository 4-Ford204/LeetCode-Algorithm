public class Solution {
    public int MinOperations(int[] nums) {
        int n = nums.Length;

        if (n == 1) return 0;

        int start = Array.IndexOf(nums, 0);
        bool increasing = true, decreasing = true;

        for (int i = 1; i < n; i++) {
            int num = nums[(start + i) % n];

            if (num != i) increasing = false;
            if (num != n - i) decreasing = false;
            if (!increasing && !decreasing) return -1;
        }

        return increasing ?
            Math.Min(start, n - start + 2) :
            Math.Min(n - start, start + 2);
    }
}