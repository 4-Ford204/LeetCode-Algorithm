public class Solution {
    public int NumberOfPaths(int[][] grid, int k) {
        int m = grid.Length, n = grid[0].Length, modulo = 1_000_000_007;
        var dp = new long[m + 1, n + 1, k];

        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                var value = grid[i - 1][j - 1] % k;

                if (i == 1 && j == 1) {
                    dp[i, j, value] = 1;
                    continue;
                }

                for (int r = 0; r < k; r++) {
                    var previous = (r - value + k) % k;
                    dp[i, j, r] = (dp[i - 1, j, previous] + dp[i, j - 1, previous]) % modulo;
                }
            }
        }

        return (int)dp[m, n, 0];
    }
}