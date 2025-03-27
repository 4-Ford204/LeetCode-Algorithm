public class Solution {
    public int CountSquares(int[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length, result = 0;
        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (matrix[i][j] == 1) {
                    dp[i + 1, j + 1] = Math.Min(dp[i, j], Math.Min(dp[i, j + 1], dp[i + 1, j])) + 1;
                    result += dp[i + 1, j + 1];
                }
            }
        }

        return result;
    }
}