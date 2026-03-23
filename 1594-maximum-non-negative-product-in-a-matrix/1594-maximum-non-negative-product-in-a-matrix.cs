public class Solution {
    public int MaxProductPath(int[][] grid) {
        int modulo = 1_000_000_007;
        int m = grid.Length, n = grid[0].Length;
        var min = new long[m, n];
        var max = new long[m, n];

        max[0, 0] = min[0, 0] = grid[0][0];

        for (int i = 1; i < m; i++)
            max[i, 0] = min[i, 0] = max[i - 1, 0] * grid[i][0];

        for (int j = 1; j < n; j++)
            max[0, j] = min[0, j] = max[0, j - 1] * grid[0][j];

        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                var value = grid[i][j];
                var a = max[i - 1, j] * value;
                var b = min[i - 1, j] * value;
                var c = max[i, j - 1] * value;
                var d = min[i, j - 1] * value;
                max[i, j] = Math.Max(Math.Max(a, b), Math.Max(c, d));
                min[i, j] = Math.Min(Math.Min(a, b), Math.Min(c, d));
            }
        }
        
        var result = max[m - 1, n - 1] % 1_000_000_007;
        return result < 0 ? -1 : (int)(result);
    }
}