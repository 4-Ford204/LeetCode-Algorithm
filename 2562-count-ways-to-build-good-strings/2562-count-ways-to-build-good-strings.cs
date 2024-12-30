public class Solution {
    public int CountGoodStrings(int low, int high, int zero, int one) {
        int modulo = 1_000_000_007, total = 0;
        int[] dp = new int[high + 1];
        dp[0] = 1;

        for (int i = 1; i <= high; i++) {
            if (i >= zero) dp[i] = (dp[i] + dp[i - zero]) % modulo;
            if (i >= one) dp[i] = (dp[i] + dp[i - one]) % modulo;
        }

        for (int i = low; i <= high; i++) total = (total + dp[i]) % modulo;

        return total;
    }
}