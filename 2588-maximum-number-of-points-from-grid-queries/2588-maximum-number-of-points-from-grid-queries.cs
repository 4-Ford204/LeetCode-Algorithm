public class Solution {
    public int[] MaxPoints(int[][] grid, int[] queries) {
        int m = grid.Length, n = grid[0].Length, k = queries.Length, point = 0;
        int[][] sortedQueries = new int[k][];
        int[][] directions = [[-1, 0], [1, 0], [0, -1], [0, 1]];
        var heap = new PriorityQueue<(int value, int row, int column), int>();
        bool[,] visited = new bool[m, n];
        int[] answer = new int[k];

        for (int i = 0; i < k; i++) sortedQueries[i] = new int[] { queries[i], i };

        Array.Sort(sortedQueries, (x, y) => x[0].CompareTo(y[0]));
        heap.Enqueue((grid[0][0], 0, 0), grid[0][0]);
        visited[0, 0] = true;

        foreach (var query in sortedQueries) {
            int queryValue = query[0], queryIndex = query[1];

            while (heap.Count > 0 && heap.Peek().value < queryValue) {
                var (value, row, column) = heap.Dequeue();
                point++;

                foreach (var direction in directions) {
                    int nextRow = row + direction[0], nextColumn = column + direction[1];

                    if (nextRow >= 0 && nextRow < m && nextColumn >= 0 && nextColumn < n && !visited[nextRow, nextColumn]) {
                        heap.Enqueue((grid[nextRow][nextColumn], nextRow, nextColumn), grid[nextRow][nextColumn]);
                        visited[nextRow, nextColumn] = true;
                    }
                }
            }

            answer[queryIndex] = point;
        }

        return answer;
    }
}