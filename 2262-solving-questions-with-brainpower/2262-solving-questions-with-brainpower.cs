public class Solution {
    public long MostPoints(int[][] questions) {
        int n = questions.Length;
        long[] dp = new long[n + 1];

        for (int i = n - 1; i >= 0; i--) {
            long points = questions[i][0];
            int brainpower = questions[i][1];
            int next = i + brainpower + 1;
            dp[i] = Math.Max(dp[i + 1], points + (next < n ? dp[next] : 0));
        }

        return dp[0];
    }
}