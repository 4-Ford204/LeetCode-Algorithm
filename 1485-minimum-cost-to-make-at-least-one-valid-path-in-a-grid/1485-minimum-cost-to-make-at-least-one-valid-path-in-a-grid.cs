public class Solution {
    public int MinCost(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int[,] cost = new int[m, n];
        var heap = new PriorityQueue<(int, int), int>();
        int[][] directions =  [[0, 1], [0, -1], [1, 0], [-1, 0]];

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++) cost[i, j] = int.MaxValue;
        cost[0, 0] = 0;
        heap.Enqueue((0, 0), 0);

        while (heap.Count > 0) {
            var (row, column) = heap.Dequeue();
            int direction = grid[row][column] - 1;
            int nextRow = row + directions[direction][0];
            int nextColumn = column + directions[direction][1];

            if (row == m - 1 && column == n - 1) return cost[row, column];

            if (
                nextRow >= 0 && nextRow < m &&
                nextColumn >= 0 && nextColumn < n &&
                cost[nextRow, nextColumn] > cost[row, column]
            ) {
                cost[nextRow, nextColumn] = cost[row, column];
                heap.Enqueue((nextRow, nextColumn), cost[nextRow, nextColumn]);
            }

            for (int i = 0; i < 4; i++) {
                nextRow = row + directions[i][0];
                nextColumn = column + directions[i][1];

                if (
                    nextRow >= 0 && nextRow < m &&
                    nextColumn >= 0 && nextColumn < n &&
                    cost[nextRow, nextColumn] > cost[row, column] + 1
                ) {
                    cost[nextRow, nextColumn] = cost[row, column] + 1;
                    heap.Enqueue((nextRow, nextColumn), cost[nextRow, nextColumn]);
                }
            }
        }

        return -1;
    }
}