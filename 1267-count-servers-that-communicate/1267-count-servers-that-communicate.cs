public class Solution {
    public int CountServers(int[][] grid) {
        int m = grid.Length, n = grid[0].Length, result = 0;
        int[] serverRows = new int[m], serverColumns = new int[n];

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1) {
                    serverRows[i]++;
                    serverColumns[j]++;
                }
            }
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1 && (serverRows[i] > 1 || serverColumns[j] > 1))
                    result++;
            }
        }

        return result;
    }
}