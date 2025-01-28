public class Solution {
    public int FindMaxFish(int[][] grid) {
        return DFS(grid);
    }

    private int BFS(int[][] grid) {
        int m = grid.Length, n = grid[0].Length, result = 0;
        int[][] directions = [[0, 1], [0, -1], [1, 0], [-1, 0]];

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] > 0) {
                    int fishes = 0;
                    Queue<(int, int)> queue = new Queue<(int, int)>();
                    queue.Enqueue((i, j));

                    while(queue.Count > 0) {
                        var (row, column) = queue.Dequeue();
                        fishes += grid[row][column];
                        grid[row][column] = 0;

                        for (int k = 0; k < directions.Length; k++) {
                            int nextRow = row + directions[k][0];
                            int nextColumn = column + directions[k][1];

                            if (nextRow >= 0 && nextRow < m && nextColumn >= 0 && nextColumn < n && grid[nextRow][nextColumn] > 0) queue.Enqueue((nextRow, nextColumn));
                        }
                    }

                    result = Math.Max(result, fishes);
                }
            }
        }

        return result;
    }

    private int DFS(int[][] grid) {
        int m = grid.Length, n = grid[0].Length, result = 0;

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] > 0) result = Math.Max(result, DFS_Recursion(grid, i, j));
            }
        }

        return result;
    }

    private int DFS_Recursion(int[][] grid, int row, int column) {
        if (row < 0 || row >= grid.Length || column < 0 || column >= grid[0].Length || grid[row][column] == 0) return 0;
        else {
            int fishes = grid[row][column];
            grid[row][column] = 0;

            return fishes +
                DFS_Recursion(grid, row, column + 1) +
                DFS_Recursion(grid, row, column - 1) +
                DFS_Recursion(grid, row + 1, column) +
                DFS_Recursion(grid, row - 1, column);
        }
    }
}