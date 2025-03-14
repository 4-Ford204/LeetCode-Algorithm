public class Solution {
    public int MaximumCandies(int[] candies, long k) {
        long total = 0;
        int left = 1, right = 0;

        foreach (var candy in candies) {
            total += candy;
            right = Math.Max(right, candy);
        }

        if (total <= k) return (int)Math.Max(total - k, -1) + 1;

        while (left < right) {
            long piles = 0;
            int middle = left + (right - left + 1) / 2;

            foreach (var candy in candies) piles += candy / middle;

            if (piles >= k) left = middle;
            else right = middle - 1;
        }

        return left;
    }
}