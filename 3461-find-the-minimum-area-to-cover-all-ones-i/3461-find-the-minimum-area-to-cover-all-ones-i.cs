public class Solution {
    public int MinimumArea(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int minV = m, minH = n, maxV = 0, maxH = 0;
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1) {
                    minV = Math.Min(minV, i);
                    minH = Math.Min(minH, j);
                    maxV = Math.Max(maxV, i);
                    maxH = Math.Max(maxH, j);
                }
            }
        }

        return (maxV - minV + 1) * (maxH - minH + 1);
    }
}