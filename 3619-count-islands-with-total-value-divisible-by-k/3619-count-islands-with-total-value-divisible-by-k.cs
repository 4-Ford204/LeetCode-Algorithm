public class Solution {
    public int CountIslands(int[][] grid, int k) {
        int m = grid.Length, n = grid[0].Length, result = 0;
        var visited = new bool[m, n];
        var direction = new int[] { -1, 0, 1, 0, -1 };

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 0 || visited[i, j]) continue;

                var sum = 0L;
                var queue = new Queue<int[]>();

                visited[i, j] = true;
                queue.Enqueue(new int[] { i, j });

                while (queue.Count > 0) {
                    var current = queue.Dequeue();
                    sum += grid[current[0]][current[1]];

                    for (int d = 0; d < 4; d++) {
                        int x = current[0] + direction[d];
                        int y = current[1] + direction[d + 1];

                        if (x >= 0 && x < m && y >= 0 && y < n && grid[x][y] > 0 && !visited[x, y]) {
                            visited[x ,y] = true;
                            queue.Enqueue(new int[] { x, y });
                        }
                    }
                }

                if (sum % k == 0) result++;
            }
        }

        return result;
    }
}