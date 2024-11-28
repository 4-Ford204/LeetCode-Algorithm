public class Solution {
    public int MinimumObstacles(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int[][] directions = [[1, 0], [0, 1], [0, -1], [-1, 0]];
        int[,] dp = new int[m, n];
        LinkedList<(int, int)> circularQueue = new LinkedList<(int, int)>();

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) dp[i, j] = int.MaxValue;
        }

        dp[0, 0] = 0;
        circularQueue.AddFirst((0, 0));

        while (circularQueue.Count > 0) {
            var current = circularQueue.First.Value;
            circularQueue.RemoveFirst();

            if (current.Item1 == m - 1 && current.Item2 == n)
                return dp[current.Item1, current.Item2];

            for (int i = 0; i < directions.Length; i++) {
                int row = current.Item1 + directions[i][0];
                int column = current.Item2 + directions[i][1];

                if (row >= 0 && row < m && column >= 0 && column < n) {
                    int removeObstacles = dp[current.Item1, current.Item2] + grid[row][column];

                    if (removeObstacles < dp[row, column]) {
                        dp[row, column] = removeObstacles;

                        if (grid[row][column] == 0) circularQueue.AddFirst((row, column));
                        else circularQueue.AddLast((row, column));
                    }
                }
            }
        }

        return dp[m - 1, n - 1];
    }
}