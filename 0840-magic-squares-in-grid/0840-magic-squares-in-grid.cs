public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        int result = 0;

        for (int i = 0; i <= grid.Length - 3; i++) {
            for (int j = 0; j <= grid[0].Length - 3; j++) {
                if (IsMagicSquare(grid, i, j)) result++;
            }
        }

        return result;
    }

    private bool IsMagicSquare(int[][] grid, int a, int b) {
        var seen = new bool[10];

        if (grid[a + 1][b + 1] != 5) return false;

        for (int i = a; i < a + 3; i++) {
            for (int j = b; j < b + 3; j++) {
                int value = grid[i][j];
                if (value < 1 || value > 9 || seen[value]) return false;
                seen[value] = true;
            }
        }

        int sum = grid[a][b] + grid[a][b + 1] + grid[a][b + 2];

        for (int i = 0; i < 3; i++) {
            if (grid[a + i][b] + grid[a + i][b + 1] + grid[a + i][b + 2] != sum) return false;
        }

        for (int i = 0; i < 3; i++) {
            if (grid[a][b + i] + grid[a + 1][b + i] + grid[a + 2][b + i] != sum) return false;
        }

        if (grid[a][b] + grid[a + 1][b + 1] + grid[a + 2][b + 2] != sum) return false;
        if (grid[a][b + 2] + grid[a + 1][b + 1] + grid[a + 2][b] != sum) return false;

        return true;
    }
}
