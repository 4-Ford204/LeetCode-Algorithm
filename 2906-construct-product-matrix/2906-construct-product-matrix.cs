public class Solution {
    public int[][] ConstructProductMatrix(int[][] grid) {
        int n = grid.Length, m = grid[0].Length, modulo = 12345;
        var result = new int[n][];
        var suffix = 1L;
        var prefix = 1L;

        for (int i = 0; i < n; i++) result[i] = new int[m];

        for (int i = n - 1; i >= 0; i--) {
            for (int j = m - 1; j >= 0; j--) {
                result[i][j] = (int)suffix;
                suffix = suffix * grid[i][j] % modulo;
            }
        }

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                result[i][j] = (int)(result[i][j] * prefix % modulo);
                prefix = prefix * grid[i][j] % modulo;
            }
        }

        return result;
    }
}