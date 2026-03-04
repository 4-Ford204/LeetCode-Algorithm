public class Solution {
    public char FindKthBit(int n, int k) {
        return (char)('1' - ((k / (k & -k) / 2 + k) % 2));
    }
}