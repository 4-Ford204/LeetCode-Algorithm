public class Solution {
    public int MaximumAmount(int[][] coins) {
        int m = coins.Length, n = coins[0].Length;
        var dp = new int[m, n, 3];

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                for (int k = 0; k < 3; k++) dp[i, j, k] = int.MinValue;
            }
        }

        return DFS(coins, dp, 0, 0, 2);
    }

    private int DFS(int[][] coins, int[,,] dp, int i, int j, int k) {
        int m = coins.Length, n = coins[0].Length;
        if (i >= m || j >= n) return int.MinValue;

        int x = coins[i][j];
        if (i == m - 1 && j == n - 1) return k > 0 ? Math.Max(0, x) : x;

        if (dp[i, j, k] != int.MinValue) return dp[i, j, k];

        int result = x + Math.Max(
            DFS(coins, dp, i + 1, j, k),
            DFS(coins, dp, i, j + 1, k)
        );

        if (k > 0 && x < 0)
            result = Math.Max(
                result,
                Math.Max(
                    DFS(coins, dp, i + 1, j, k - 1),
                    DFS(coins, dp, i, j + 1, k - 1)
                )
            );

        dp[i, j, k] = result;
        return result;
    }
}