public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length;
        bool setFirstColumn = false, setFirstRow = false;

        for (int i = 0; i < m; i++) {
            if (matrix[i][0] == 0) {
                setFirstColumn = true;
                break;
            }
        }

        for (int i = 0; i < n; i++) {
            if (matrix[0][i] == 0) {
                setFirstRow = true;
                break;
            }
        }

        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                if (matrix[i][j] == 0) {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }

        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                if (matrix[i][0] == 0 || matrix[0][j] == 0) matrix[i][j] = 0;
            }
        }

        if (setFirstColumn) {
            for (int i = 0; i < m; i++) matrix[i][0] = 0; 
        }

        if (setFirstRow) {
            for (int i = 0; i < n; i++) matrix[0][i] = 0;
        }
    }
}