public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int i = 0, n = bits.Length;

        while (i < n - 1) i += bits[i] + 1;

        return i == n - 1;
    }
}