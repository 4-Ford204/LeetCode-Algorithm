public class Solution {
    public int MinimumCost(int[] cost) {
        int item = 0, result = 0;
        Array.Sort(cost);

        for (int i = cost.Length - 1; i >= 0; i--) {
            if (item == 2) {
                item = 0;
                continue;
            }
                
            result += cost[i];
            item++;
        }

        return result;
    }
}