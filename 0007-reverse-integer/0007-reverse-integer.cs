public class Solution {
    public int Reverse(int x) {
        long reverse = 0;

        while (x != 0) {
            reverse = reverse * 10 + x % 10;
            x /= 10;
        }

        return (reverse < int.MinValue || reverse >= int.MaxValue) ? 0 : (int)reverse;
    }
}