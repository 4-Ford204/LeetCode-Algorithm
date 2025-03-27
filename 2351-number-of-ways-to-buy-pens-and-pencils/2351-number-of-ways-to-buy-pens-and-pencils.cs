public class Solution {
    public long WaysToBuyPensPencils(int total, int cost1, int cost2) {
        long result = 0;

        for (int i = 0; i <= total / cost1; i++)
            result += (total - cost1 * i) / cost2 + 1;

        return result;
    }
}