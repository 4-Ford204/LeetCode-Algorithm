public class Solution {
    public void GameOfLife(int[][] board) {
        int m = board.Length, n = board[0].Length;
        int[][] directions = new int[][] {new int[] { -1, -1 }, new int[] { -1, 0 }, new int[] { -1, 1 }, new int[] { 0, 1 }, new int[] { 1, 1 }, new int[] { 1, 0 }, new int[] { 1, -1 }, new int[] { 0, -1 } };

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                int neighbor = 0, current = board[i][j];

                foreach (var direction in directions) {
                    int row = i + direction[0], column = j + direction[1];

                    if (row >= 0 && row < m && column >= 0 && column < n) {
                        if ((board[row][column] & 1) == 1) neighbor++;
                    }
                }

                if (neighbor == 2) board[i][j] = (current << 1) + current;
                if (neighbor == 3) board[i][j] = (1 << 1) + current;
            }
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) board[i][j] >>= 1;
        }
    }
}