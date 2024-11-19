public class Solution {
    public int NumTilings(int n) {
        long modulo = 1000000007;
        long[] dp = new long[n + 1];
        long[] dpt = new long[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        for (int i = 2; i <= n; i++) {
            dpt[i] = (dpt[i - 1] + dp[i - 2]) % modulo;
            dp[i] = (2 * dpt[i - 1] + dp[i - 1] + dp[i - 2]) % modulo;
        }
        return (int)dp[n];
    }
}