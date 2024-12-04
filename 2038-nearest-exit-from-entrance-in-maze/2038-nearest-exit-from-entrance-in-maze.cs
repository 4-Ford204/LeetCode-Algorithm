public class Solution {
    public int NearestExit(char[][] maze, int[] entrance) {
        int m = maze.Length;
        int n = maze[0].Length;
        int[][] directions = [[-1, 0], [0, 1], [1, 0], [0, -1]];
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        queue.Enqueue((entrance[0], entrance[1], 0));
        maze[entrance[0]][entrance[1]] = '+';

        while (queue.Count() > 0) {
            var (positionY, positionX, steps) = queue.Dequeue();

            foreach (var direction in directions) {
                int nextY = positionY + direction[0];
                int nextX = positionX + direction[1];

                if (nextY >= 0 && nextY < m && nextX >= 0 && nextX < n && maze[nextY][nextX] == '.') {
                    if (nextY == 0 || nextY == m - 1 || nextX == 0 || nextX == n - 1)
                        return steps + 1;

                    maze[nextY][nextX] = '+';
                    queue.Enqueue((nextY, nextX, steps + 1));
                }
            }
        }

        return -1;
    }
}