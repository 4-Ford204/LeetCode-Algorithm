public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        int pre_7 = 0, pre_30 = 0;
        int min_2 = Math.Min(costs[1], costs[2]), min_3 = Math.Min(costs[0], min_2);
        int[] dp = new int[days.Length];
        dp[0] = min_3;
        
        for (int i = 1; i < days.Length; i++) {
            while (days[i] - days[pre_7] >= 7) pre_7++;
            while (days[i] - days[pre_30] >= 30) pre_30++;
            
            dp[i] = dp[i - 1] + min_3;
            if (pre_7 > 0) dp[i] = Math.Min(dp[i], dp[pre_7 - 1] + min_2);
            else dp[i] = Math.Min(dp[i], min_2);
            if (pre_30 > 0) dp[i] = Math.Min(dp[i], dp[pre_30 - 1] + costs[2]);
            else dp[i] = Math.Min(dp[i], costs[2]);
        }

        return dp[days.Length - 1];
    }
}