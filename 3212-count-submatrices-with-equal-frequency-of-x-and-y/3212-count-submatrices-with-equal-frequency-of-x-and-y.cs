public class Solution {
    public int NumberOfSubmatrices(char[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int result = 0;
        var prefix = new int[2, n];

        for (int i = 0; i < m; i++) {
            int X = 0, Y = 0;

            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 'X') prefix[0, j]++;
                if (grid[i][j] == 'Y') prefix[1, j]++;

                X += prefix[0, j];
                Y += prefix[1, j];

                if (X > 0 && X == Y) result++;
            }
        }

        return result;
    }
}