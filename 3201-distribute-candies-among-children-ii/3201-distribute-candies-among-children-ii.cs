public class Solution {
    public long DistributeCandies(int n, int limit) {
        return
            Calculate(n + 2) -
            3 * Calculate(n - limit + 1) +
            3 * Calculate(n - (limit + 1) * 2 + 2) -
            Calculate(n - 3 * (limit + 1) + 2);
    }

    private long Enumeration(int n, int limit) {
        long result = 0;

        for (int i = 0; i <= Math.Min(n ,limit); i++) {
            if (n - i > 2 * limit) continue;
            result += Math.Min(n - i, limit) - Math.Max(0, n - i - limit) + 1;
        }

        return result;
    }

    private long Calculate(int x) {
        return x < 0 ? 0 : (long)x * (x - 1) / 2;
    }
}