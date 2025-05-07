public class Solution {
    public int MinTimeToReach(int[][] moveTime) {
        int n = moveTime.Length, m = moveTime[0].Length;
        var queue = new PriorityQueue<(int, int, int), int>(Comparer<int>.Create((x, y) => x - y));
        bool[,] visited = new bool[n, m];
        int[][] directions = new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 }, new int[] { -1, 0 }, new int[] { 0, -1 } };

        queue.Enqueue((0, 0, 0), 0);
        visited[0, 0] = true;

        while (queue.Count > 0) {
            var (row, column, time) = queue.Dequeue();

            if (row == n - 1 && column == m - 1) return time;

            foreach (var direction in directions) {
                int nextRow = row + direction[0];
                int nextColumn = column + direction[1];

                if (nextRow >= 0 && nextRow < n && nextColumn >= 0 && nextColumn < m && !visited[nextRow, nextColumn]) {
                    int nextTime = Math.Max(time, moveTime[nextRow][nextColumn]) + 1;

                    queue.Enqueue((nextRow, nextColumn, nextTime), nextTime);
                    visited[nextRow, nextColumn] = true;
                }
            }
        }

        return -1;
    }
}