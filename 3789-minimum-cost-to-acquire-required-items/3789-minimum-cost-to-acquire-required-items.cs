public class Solution {
    public long MinimumCost(int cost1, int cost2, int costBoth, int need1, int need2) {
        var min = Math.Min(need1, need2);
        
        return cost1 + cost2 <= costBoth ?
            1L * cost1 * need1 + 1L * cost2 * need2 :
            (
                1L * costBoth * min +
                1L * Math.Max(0, need1 - min) * Math.Min(cost1, costBoth) +
                1L * Math.Max(0, need2 - min) * Math.Min(cost2, costBoth)
            );
    }
}