public class Solution {
    public int[][] SortMatrix(int[][] grid) {
        int n = grid.Length;

        for (int i = 0; i < n; i++) {
            int row = i, column = 0;
            int[] diagonal = new int[n - i];

            while (row < n && column < n) diagonal[column] = grid[row++][column++];

            Array.Sort(diagonal);
            Array.Reverse(diagonal);

            while (--row >= 0 && --column >= 0) grid[row][column] = diagonal[column];
        }

        for (int i = 1; i < n; i++) {
            int row = 0, column = i;
            int[] diagonal = new int[n - i];

            while (row < n && column < n) diagonal[row] = grid[row++][column++];

            Array.Sort(diagonal);

            while (--row >= 0 && --column >= 0) grid[row][column] = diagonal[row];
        }

        return grid;
    }
}