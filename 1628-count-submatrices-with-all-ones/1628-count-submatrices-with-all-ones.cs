public class Solution {
    public int NumSubmat(int[][] mat) {
        int m = mat.Length, n = mat[0].Length, result = 0;
        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (mat[i][j] == 1) dp[i + 1, j + 1] = dp[i + 1, j] + 1;

                var current = dp[i + 1, j + 1];

                for (int k = i; k >= 0; k--) {
                    current = Math.Min(current, dp[k + 1, j + 1]);

                    if (current == 0) break;

                    result += current;
                }
            }
        }

        return result;
    }
}