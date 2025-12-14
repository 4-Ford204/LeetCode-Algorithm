public class Solution {
    public int NumberOfWays(string corridor) {
        int modulo = 1_000_000_007;
        int a = 1, b = 0, c = 0;

        foreach (var letter in corridor) {
            a = (a + c) % modulo;

            if (letter == 'S') {
                c = b;
                b = a;
                a = 0;
            }
        }

        return c;
    }
}