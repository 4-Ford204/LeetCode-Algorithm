public class Solution {
    public int NumberOfWays(int n, int x) {
        int modulo = 1_000_000_007;
        long[] dp = new long[n + 1];
        dp[0] = 1; 

        for (int i = 1; i <= n; i++) {
            var value = (long)Math.Pow(i, x);
            
            if (value > n) {
                break;
            }

            for (int j = n; j >= value; j--)
                dp[j] = (dp[j] + dp[j - value]) % modulo;
        }

        return (int)dp[n];
    }
}
