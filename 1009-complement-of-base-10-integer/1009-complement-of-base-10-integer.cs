public class Solution {
    public int BitwiseComplement(int n) {
        int mask = 1;

        if (n == 0) return 1;
        else {
            while (mask <= n) mask <<= 1;
            return (mask - 1) ^ n;
        }
    }
}