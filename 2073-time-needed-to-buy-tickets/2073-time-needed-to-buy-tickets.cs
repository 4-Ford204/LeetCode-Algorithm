public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int n = tickets.Length, result = tickets[k];

        for (int i = 0; i < k; i++)
            result += Math.Min(tickets[i], tickets[k]);
        
        for (int i = k + 1; i < n; i++) 
            result += Math.Min(tickets[i], tickets[k] - 1);

        return result;
    }
}