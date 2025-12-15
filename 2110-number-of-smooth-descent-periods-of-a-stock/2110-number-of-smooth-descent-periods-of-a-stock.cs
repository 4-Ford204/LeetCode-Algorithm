public class Solution {
    public long GetDescentPeriods(int[] prices) {
        int n = prices.Length, dp = 1;
        long result = 1;

        for (int i = 1; i < n; i++) {
            dp = (prices[i] == prices[i - 1] - 1) ? dp + 1 : 1;
            result += dp;
        }

        return result;
    }
}