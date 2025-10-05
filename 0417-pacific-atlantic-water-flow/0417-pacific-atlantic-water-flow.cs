public class Solution {
    int[][] directions = new int[][] {
        new[] { 0, 1 }, new[] { 1, 0 }, new[] { 0, -1 }, new[] { -1, 0 }
    };

    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        int m = heights.Length, n = heights[0].Length;
        bool[][] pVisited = new bool[m][];
        bool[][] aVisited = new bool[m][];
        var result = new List<IList<int>>();

        for (int i = 0; i < m; i++) {
            pVisited[i] = new bool[n];
            aVisited[i] = new bool[n];
        }

        for (int i = 0; i < m; i++) {
            BFS(heights, pVisited, i, 0);
            BFS(heights, aVisited, i, n - 1);
        }

        for (int j = 0; j < n; j++) {
            BFS(heights, pVisited, 0, j);
            BFS(heights, aVisited, m - 1, j);
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (pVisited[i][j] && aVisited[i][j])
                    result.Add(new List<int>() { i, j });
            }
        }

        return result;
    }

    private void BFS(int[][] heights, bool[][] visited, int currentRow, int currentColumn) {
        int m = heights.Length, n = heights[0].Length;
        var queue = new Queue<(int row, int column)>();

        queue.Enqueue((currentRow, currentColumn));
        visited[currentRow][currentColumn] = true;

        while (queue.Count > 0) {
            var (row, column) = queue.Dequeue();

            foreach (var direction in directions) {
                int nextRow = row + direction[0], nextColumn = column + direction[1];

                if (
                    nextRow >= 0 && nextRow < m &&
                    nextColumn >= 0 && nextColumn < n &&
                    !visited[nextRow][nextColumn] &&
                    heights[nextRow][nextColumn] >= heights[row][column]
                ) {
                    visited[nextRow][nextColumn] = true;
                    queue.Enqueue((nextRow, nextColumn));
                }
            }
        }
    }
}