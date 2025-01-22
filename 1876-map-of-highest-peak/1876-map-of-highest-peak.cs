public class Solution {
    public int[][] HighestPeak(int[][] isWater) {
        int m = isWater.Length, n = isWater[0].Length;
        int[][] result = new int[m][], directions = [[-1, 0], [0, 1], [1, 0], [0, -1]];
        Queue<(int, int)> queue = new Queue<(int, int)>();

        for (int i = 0; i < m; i++) result[i] = new int[n];

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (isWater[i][j] == 1) queue.Enqueue((i, j));
                else result[i][j] = -1;
            }
        }

        while (queue.Count > 0) {
            var (row, column) = queue.Dequeue();

            for (int i = 0; i < directions.Length; i++) {
                int nextRow = row + directions[i][0];
                int nextColumn = column + directions[i][1];

                if (nextRow >= 0 && nextRow < m && nextColumn >= 0 && nextColumn < n && result[nextRow][nextColumn] == -1) {
                    queue.Enqueue((nextRow, nextColumn));
                    result[nextRow][nextColumn] = result[row][column] + 1;
                }
            }
        }

        return result;
    }
}