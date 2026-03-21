public class Solution {
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k) {
        for (int start = x, end = x + k - 1; start < end; start++, end--) {
            for (int j = y; j < y + k; j++)
                (grid[start][j], grid[end][j]) = (grid[end][j], grid[start][j]);
        }

        return grid;
    }
}