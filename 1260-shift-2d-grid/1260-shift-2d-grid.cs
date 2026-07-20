public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        int m = grid.Length, n = grid[0].Length, size = m * n;
        var result = new int[m][];

        for (int i = 0; i < m; i++) result[i] = new int[n];

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                int index = (i * n + j + k) % size;
                result[index / n][index % n] = grid[i][j];
            }
        }

        return result;
    }
}