public class Solution {
    public int MirrorDistance(int n) {
        int reverse = 0, num = n;

        while (num > 0) {
            reverse = reverse * 10 + num % 10;
            num /= 10;
        }

        return Math.Abs(n - reverse);
    }
}