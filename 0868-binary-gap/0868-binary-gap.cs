public class Solution {
    public int BinaryGap(int n) {
        int current = 0, result = 0;

        while (n > 0 && (n & 1) == 0) n >>= 1;

        while (n > 0) {
            var bit = n & 1;
            n >>= 1;
            current++;

            if (bit == 1) {
                result = Math.Max(result, current - 1);
                current = 1;
            }
        }

        return result;
    }
}