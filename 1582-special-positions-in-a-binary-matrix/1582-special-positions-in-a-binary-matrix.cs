public class Solution {
    public int NumSpecial(int[][] mat) {
        int m = mat.Length, n = mat[0].Length, result = 0;
        int[] r = new int[m];
        int[] c = new int[n];

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (mat[i][j] == 1) {
                    r[i]++;
                    c[j]++;
                }
            }
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (mat[i][j] == 1 && r[i] == 1 && c[j] == 1)
                    result++;
            }
        }

        return result;
    }
}