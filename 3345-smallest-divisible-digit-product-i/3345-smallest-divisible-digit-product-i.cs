public class Solution {
    public int SmallestNumber(int n, int t) {
        int product = 1, num = n;

        while (num > 0) {
            product *= num % 10;
            num /= 10;
        }

        if (product % t > 0) return SmallestNumber(n + 1, t);

        return n;
    }
}