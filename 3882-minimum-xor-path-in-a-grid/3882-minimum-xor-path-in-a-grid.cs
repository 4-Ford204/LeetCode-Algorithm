public class Solution {
    public int MinCost(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        var dp = new bool[n][];
        var next = new bool[1024];

        for (int i = 0; i < n; i++) dp[i] = new bool[1024];

        dp[0][grid[0][0]] = true;

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (i == 0 && j == 0) continue;

                Array.Clear(next, 0, next.Length);

                for (int k = 0; k < 1024; k++) {
                    if (dp[j][k] || (j > 0 && dp[j - 1][k]))
                        next[k ^ grid[i][j]] = true;
                }

                Array.Copy(next, dp[j], 1024);
            }
        }

        return Array.IndexOf(dp[n - 1], true);
    }
}