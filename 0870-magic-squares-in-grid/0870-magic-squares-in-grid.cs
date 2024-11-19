public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        int rowNumber = grid.Length;
        int columnNumber = grid[0].Length;
        int count = 0;

        if (rowNumber < 3 || columnNumber < 3) return count;

        for (int i = 0; i < rowNumber - 2; i++) {
            for (int j = 0; j < columnNumber - 2; j++) {
                if (IsMagicSquare(grid, i, j)) count++;
            }
        }

        return count;
    }

    private bool IsMagicSquare(int[][] grid, int row, int column) {
        string sequence = "2943816729438167";
        string sequenceReversed = "7618349276183492";

        StringBuilder border = new StringBuilder();
        int[] borderIndices = new int[] { 0, 1, 2, 5, 8, 7, 6, 3 };
        foreach(var i in borderIndices) {
            int num = grid[row + i / 3][column + i % 3];
            border.Append(num);
        }
        string borderConverted = border.ToString();

        return grid[row][column] % 2 == 0 &&
            (sequence.Contains(borderConverted) || sequenceReversed.Contains(borderConverted)) &&
            grid[row + 1][column + 1] == 5;
    }
}