public class Solution {
    public int OrangesRotting(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int[][] directions = [[-1, 0], [0, 1], [1, 0], [0, -1]];
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        int freshOrange = 0;
        int minMinute = 0;

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 2) queue.Enqueue((i, j, 0));
                else if (grid[i][j] == 1) freshOrange++;
            }
        }

        while (queue.Count() > 0 && freshOrange > 0) {
            var (positionY, positionX, minute) = queue.Dequeue();

            foreach (var direction in directions) {
                int nextY = positionY + direction[0];
                int nextX = positionX + direction[1];

                if (nextY >= 0 && nextY < m && nextX >= 0 && nextX < n && grid[nextY][nextX] == 1) {
                    queue.Enqueue((nextY, nextX, minute + 1));
                    grid[nextY][nextX] = 2;
                    freshOrange--;
                    minMinute = Math.Max(minMinute, minute + 1);
                }
            }
        }

        return freshOrange > 0 ? -1 : minMinute;
    }
}