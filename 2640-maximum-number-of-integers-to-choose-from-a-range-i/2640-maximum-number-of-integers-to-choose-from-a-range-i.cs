public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum) {
        int result = 0, total = 0;
        bool[] numbers = new bool[n + 1];

        foreach (var ban in banned) {
            if (ban <= n) numbers[ban] = true;
        }

        for (int i = 1; i <= n; i++) {
            if (numbers[i]) continue;
            else {
                total += i;

                if (total <= maxSum) result++;
                else break;
            }
        }

        return result;
    }
}