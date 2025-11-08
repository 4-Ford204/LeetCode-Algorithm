public class Solution {
    public int MinimumOneBitOperations(int n) {
        int current = 1, k = 0;

        if (n == 0) return 0;

        while (current * 2 <= n) {
            current *= 2;
            k++;
        }

        return (1 << (k + 1)) - 1 - MinimumOneBitOperations(n ^ current);
    }
}