public class Solution {
    public int LargestSubmatrix(int[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length;
        int result = 0;

        for (int j = 0; j < n; j++) {
            for (int i = 1; i < m; i++)
                matrix[i][j] = matrix[i][j] == 0 ? 0 : matrix[i - 1][j] + 1;
        }

        for (int i = 0; i < m; i++) {
            Array.Sort(matrix[i], (a, b) => b.CompareTo(a));

            for (int j = 0; j < n; j++)
                result = Math.Max(result, (j + 1) * matrix[i][j]);
        }

        return result;

    }
}