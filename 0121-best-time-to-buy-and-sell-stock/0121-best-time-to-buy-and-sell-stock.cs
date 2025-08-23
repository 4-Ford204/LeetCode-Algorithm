public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length, current = int.MaxValue, result = 0;

        for (int i = 0; i < n; i++) {
            if (current > prices[i]) current = prices[i];
            else result = Math.Max(result, prices[i] - current);
        }

        return result;
    }
}