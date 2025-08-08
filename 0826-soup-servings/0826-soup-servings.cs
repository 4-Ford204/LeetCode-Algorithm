public class Solution {
    public double SoupServings(int n) {
        if (n >= 10_000) return 1.0;

        int serving = (int)Math.Ceiling(n / 25.0);
        var dp = new double?[serving + 1, serving + 1];

        return Memoization(serving, serving, dp);
    }

    private double Memoization(int a, int b, double?[,] dp) {
        if (a <= 0 && b <= 0) return 0.5;
        if (a <= 0) return 1.0;
        if (b <= 0) return 0.0;
        if (dp[a, b].HasValue) return dp[a, b].Value;
        
        dp[a, b] = 0.25 * (
            Memoization(a - 4, b, dp) +
            Memoization(a - 3, b - 1, dp) +
            Memoization(a - 2, b - 2, dp) +
            Memoization(a - 1, b - 3, dp)
        );

        return dp[a, b].Value;
    }
}
