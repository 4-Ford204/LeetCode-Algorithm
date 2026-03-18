public class Solution {
    public int CountSubmatrices(int[][] grid, int k) {
        int m = grid.Length, n = grid[0].Length, result = 0;
        int[] prefix = new int[n];

        for (int i = 0; i < m; i++) {
            int sum = 0;

            for (int j = 0; j < n; j++) {
                prefix[j] += grid[i][j];
                sum += prefix[j];

                if (sum <= k) result++;
            }
        }

        return result;
    }
}