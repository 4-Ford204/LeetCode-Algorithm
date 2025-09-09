public class Solution {
    public int PeopleAwareOfSecret(int n, int delay, int forget) {
        int modulo = 1_000_000_007;
        long current = 0, result = 0;
        long[] dp = new long[n + 1];
        dp[1] = 1;

        for (int i = 2; i <= n; i++) {
            int shareIndex = i - delay;
            int forgetIndex = i - forget;

            if (shareIndex >= 1)
                current = (current + dp[shareIndex]) % modulo;

            if (forgetIndex >= 1)
                current = (current - dp[forgetIndex] + modulo) % modulo;

            dp[i] = current;
        }
        
        for (int i = Math.Max(1, n - forget + 1); i <= n; i++)
            result = (result + dp[i]) % modulo;

        return (int)result;
    }
}