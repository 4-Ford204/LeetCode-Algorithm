public class Solution {
    public int DistinctSubseqII(string s) {
        int MOD = 1_000_000_007, n = s.Length;
        int[] dp = new int[n + 1], end = new int[26];

        dp[0] = 1;
        Array.Fill(end, -1);

        for (int i = 0; i < n; i++) {
            int index = s[i] - 'a';
            dp[i + 1] = (dp[i] * 2) % MOD;
            
            if (end[index] != -1)
                dp[i + 1] = (dp[i + 1] - dp[end[index]] + MOD) % MOD;
            
            end[index] = i;
        }

        return (dp[n] - 1 + MOD) % MOD;
    }
}