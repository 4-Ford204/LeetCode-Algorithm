public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int n = triangle.Count;
        var dp = new int[n + 1][];

        for (int i = 0; i <= n; i++) dp[i] = new int[i + 1];

        for (int i = n - 1; i >= 0; i--) {
            for (int j = i; j >= 0; j--)
                dp[i][j] = triangle[i][j] + Math.Min(dp[i + 1][j], dp[i + 1][j + 1]);
        }

        return dp[0][0];
    }
}