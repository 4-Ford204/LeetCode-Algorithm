public class Solution {
    public int MinFlips(int a, int b, int c) {
        int result = 0;

        for (int i = 0; i < 32; i++) {
            bool aBit = ((a >> i) & 1) != 0;
            bool bBit = ((b >> i) & 1) != 0;
            bool cBit = ((c >> i) & 1) != 0;

            if (!cBit) {
                if (aBit) result++;
                if (bBit) result++;
            } else {
                if (!aBit && !bBit) result++;
            }
        }

        return result;
    }
}