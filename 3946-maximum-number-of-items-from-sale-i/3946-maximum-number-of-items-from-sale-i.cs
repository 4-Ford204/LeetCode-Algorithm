public class Solution {
    public int MaximumSaleItems(int[][] items, int budget) {
        int n = items.Length, min = int.MaxValue, result = 0;
        var dp = new int[budget + 1];
        
        for (int i = 0; i < n; i++) {
            int factor = items[i][0], price = items[i][1], count = 0;
            min = Math.Min(min, price);

            for (int j = 0; j < n; j++) {
                if (items[j][0] % factor == 0) count++;
            }

            for (int j = budget; j >= price; j--)
                dp[j] = Math.Max(dp[j], dp[j - price] + count);
        }

        for (int i = 0; i <= budget; i++)
            result = Math.Max(result, dp[i] + (budget - i) / min);

        return result;
    }
}