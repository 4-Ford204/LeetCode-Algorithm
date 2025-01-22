public class Solution {
    public int TrapRainWater(int[][] heightMap) {
        int m = heightMap.Length, n = heightMap[0].Length, remain = m * n, result = 0;
        Stack<(int, int)>[] boundary = new Stack<(int, int)>[20_001];
        Span<int> directions = [0, 1, 0, -1, 0];

        void Init(int row, int column) {
            int height = heightMap[row][column];

            if (height == -1) return;
            else {
                heightMap[row][column] = -1;
                remain--;

                if (boundary[height] is null) boundary[height] = new Stack<(int, int)>();

                boundary[height].Push((row, column));
            }
        }

        for (int i = 0; i < m; i++) {
            Init(i, 0);
            Init(i, n - 1);
        }

        for (int i = 0; i < n; i++) {
            Init(0, i);
            Init(m - 1, i);
        }

        for (int height = 0; height <= 20_000; height++) {
            if (boundary[height] is null) continue;

            while (boundary[height].Count > 0) {
                var (row, column) = boundary[height].Pop();

                for (int i = 0; i < 4;) {
                    int nextRow = row + directions[i];
                    int nextColumn = column + directions[++i];

                    if (nextRow < 0 || nextRow >= m || nextColumn < 0 || nextColumn >= n || heightMap[nextRow][nextColumn] == -1) continue;

                    if (heightMap[nextRow][nextColumn] < height) {
                        result += height - heightMap[nextRow][nextColumn];
                        heightMap[nextRow][nextColumn] = height;
                    }

                    Init(nextRow, nextColumn);

                    if (remain == 0) return result;
                }
            }
        }

        return result;
    }
}