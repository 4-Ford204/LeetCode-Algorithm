public class Solution {
    public long MinTime(int[] skill, int[] mana) {
        int n = skill.Length, m = mana.Length;
        var dp = new long[n + 1];

        for (int j = 0; j < m; j++) {
            for (int i = 0; i < n; i++)
                dp[i + 1] = Math.Max(dp[i + 1], dp[i]) + skill[i] * mana[j];

            for (int i = n - 1; i > 0; i--)
                dp[i] = dp[i + 1] - skill[i] * mana[j];
        }

        return dp[^1];
    }
}