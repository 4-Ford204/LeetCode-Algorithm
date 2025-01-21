public class Solution {
    public long GridGame(int[][] grid) {
        int n = grid[0].Length;
        long prefixUpper = 0, prefixLower = 0, result = long.MaxValue;

        for (int i = 0; i < n; i++) prefixUpper += grid[0][i];

        for (int i = 0; i < n; i++) {
            prefixUpper -= grid[0][i];
            result = Math.Min(result, Math.Max(prefixUpper, prefixLower));
            prefixLower += grid[1][i];
        }

        return result;
    }
}