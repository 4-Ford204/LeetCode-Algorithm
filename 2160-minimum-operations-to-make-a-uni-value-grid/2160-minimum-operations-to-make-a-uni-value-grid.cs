public class Solution {
    public int MinOperations(int[][] grid, int x) {
        int _base = grid[0][0], m = grid.Length, n = grid[0].Length;
        List<int> flatten = new List<int>();

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                int value = grid[i][j] - _base;

                if (value % x != 0) return -1;
                else flatten.Add(value / x);
            }
        }

        flatten.Sort();
        int middle = flatten[m * n / 2], result = 0;

        foreach (var value in flatten) result += Math.Abs(value - middle);

        return result;
    }
}