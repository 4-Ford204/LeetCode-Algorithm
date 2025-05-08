public class Solution {
    public int MinTimeToReach(int[][] moveTime) {
        int n = moveTime.Length, m = moveTime[0].Length;
        var heap = new PriorityQueue<(int, int, int, int), int>(Comparer<int>.Create((x , y) => x - y));
        bool[,] visited = new bool[n, m];
        int[][] directions = new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 }, new int[] { -1, 0 }, new int[] { 0, -1 } };

        heap.Enqueue((0, 0, 0, 1), 0);
        visited[0, 0] = true;

        while (heap.Count > 0) {
            var (row, column, time, take) = heap.Dequeue();

            if (row == n - 1 && column == m - 1) return time;

            foreach (var direction in directions) {
                int nextRow = row + direction[0];
                int nextColumn = column + direction[1];

                if (nextRow >= 0 && nextRow < n && nextColumn >= 0 && nextColumn < m && !visited[nextRow, nextColumn]) {
                    int nextTime = Math.Max(time, moveTime[nextRow][nextColumn]) + take;
                    int nextTake = take ^ 3;

                    heap.Enqueue((nextRow, nextColumn, nextTime, nextTake), nextTime);
                    visited[nextRow, nextColumn] = true;
                }
            }
        }

        return -1;
    }
}