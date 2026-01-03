public class Solution {
    public int NumOfWays(int n) {
        int modulo = 1_000_000_007;
        long a = 6, b = 6;

        for (int i = 2; i <= n; i++) {
            (a, b) = (
                (2 * a + 2 * b) % modulo,
                (2 * a + 3 * b) % modulo
            );
        }
        
        return (int)((a + b) % modulo);
    }
}