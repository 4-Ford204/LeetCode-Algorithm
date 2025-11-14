public class Solution {
    public int[][] RangeAddQueries(int n, int[][] queries) {
        int[][] prefix = new int[n + 1][];
        int[][] result = new int[n][];

        for (int i = 0; i <= n; i++) prefix[i] = new int[n + 1];
        
        foreach (var query in queries) {
            prefix[query[0]][query[1]] += 1;
            prefix[query[0]][query[3] + 1] -= 1;
            prefix[query[2] + 1][query[1]] -= 1;
            prefix[query[2] + 1][query[3] + 1] += 1;
        }

        for (int i = 0; i < n; i++) result[i] = new int[n];

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                result[i][j] = prefix[i][j] + 
                    ((i == 0) ? 0 : result[i - 1][j]) +
                    ((j == 0) ? 0 : result[i][j - 1]) -
                    ((i == 0 || j == 0) ? 0 : result[i - 1][j - 1]);
            }
        }
        return result;
    }
}