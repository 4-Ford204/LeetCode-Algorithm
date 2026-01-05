public class Solution {
    public long MaxMatrixSum(int[][] matrix) {
        int n = matrix.Length, negative = 0, min = int.MaxValue;
        long result = 0;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                int value = matrix[i][j];

                if (value < 0) {
                    negative++;
                    value *= -1;
                }

                min = Math.Min(min, value);
                result += value;
            }
        }

        if (negative % 2 == 1) result -= 2 * min;

        return result;
    }
}