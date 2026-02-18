public class Solution {
    public bool HasAlternatingBits(int n) {
        var previous = n & 1;
        n >>= 1;

        while (n > 0) {
            var current = n & 1;

            if (current == previous) return false;

            previous = current;
            n >>= 1;
        }

        return true;
    }
}