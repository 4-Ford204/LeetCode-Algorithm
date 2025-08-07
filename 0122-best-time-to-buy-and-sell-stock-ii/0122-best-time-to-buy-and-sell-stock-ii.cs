public class Solution {
    public int MaxProfit(int[] prices) {
        int current = prices[0], result = 0;
        
        for (int i = 1; i < prices.Length; i++) {
            if (current < prices[i]) result += prices[i] - current;
            current = prices[i];
        }

        return result;
    }
}