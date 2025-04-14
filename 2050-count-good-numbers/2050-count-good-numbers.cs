public class Solution {
    private long MODULO = 1_000_000_007;

    public int CountGoodNumbers(long n) {
        return (int)(Pow(5, (n + 1) / 2) * Pow(4, n / 2) % MODULO);
    }

    private long Pow(int x, long n) {
        long result = 1, current = x;

        while (n > 0) {
            if (n % 2 == 1) result = result * current % MODULO;
            current = current * current % MODULO;
            n /= 2;
        }

        return result;
    }
}