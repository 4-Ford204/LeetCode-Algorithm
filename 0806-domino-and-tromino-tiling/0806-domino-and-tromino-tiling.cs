public class Solution {
    public int NumTilings(int n) {
        long modulo = 1_000_000_007;
        long[] dpd = new long[n + 1], dpt = new long[n + 1];
        dpd[0] = 1;
        dpd[1] = 1;

        for (int i = 2; i <= n; i++) {
            dpd[i] = (dpt[i - 1] + dpd[i - 1] + dpd[i - 2]) % modulo;
            dpt[i] = (dpt[i - 1] + dpd[i - 2] * 2) % modulo;
        }

        return (int)dpd[n];
    }
}