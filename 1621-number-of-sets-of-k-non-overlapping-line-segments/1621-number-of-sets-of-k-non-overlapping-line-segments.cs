public class Solution {
    public int NumberOfSets(int n, int k) {
        int MODULO = 1_000_000_007;
        var dp = new int[n];
        var prefix = new int[n + 1];

        for (int i = 0; i < n; i++) {
            dp[i] = 1;
            prefix[i + 1] = (prefix[i] + dp[i]) % MODULO;
        }

        for (int i = 1; i <= k; i++) {
            dp[0] = 0;

            for (int j = 1; j < n; j++)
                dp[j] = (dp[j - 1] + prefix[j]) % MODULO;

            for (int j = 0; j < n; j++)
                prefix[j + 1] = (prefix[j] + dp[j]) % MODULO;
        }

        return dp[n - 1];       
    }
}