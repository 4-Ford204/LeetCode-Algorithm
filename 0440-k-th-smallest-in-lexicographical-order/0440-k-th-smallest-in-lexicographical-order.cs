public class Solution {
    public int FindKthNumber(int n, int k) {
        int current = 1;
        k--;

        while (k > 0) {
            int step = CountStep(n, current, current + 1);

            if (step <= k) {
                current++;
                k -= step;
            } else {
                current *= 10;
                k--;
            }
        }

        return current;
    }

    private int CountStep(int n, long prefix1, long prefix2) {
        int step = 0;

        while (prefix1 <= n) {
            step += (int)(Math.Min(n + 1, prefix2) - prefix1);
            prefix1 *= 10;
            prefix2 *= 10;
        }

        return step;
    }
}