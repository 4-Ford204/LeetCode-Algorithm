public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        int max = 0;
        
        foreach (int cost in costs) {
            if (max < cost) max = cost;
        }

        int result = 0;
        var count = new int[max + 1];

        foreach (var cost in costs) count[cost]++;

        for (int i = 1; i <= max; i++) {
            if (coins < i) break;

            int n = Math.Min(count[i], coins / i);
            result += n;
            coins -= n * i;
        }

        return result;
    }
}