public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length, maxIndex = n - 1;

        for (int i = 0; i < n / 2; i++) {
            for (int j = i; j < maxIndex - i; j++) {
                int[,] numbers = {
                    { matrix[i][j], matrix[j][maxIndex - i] },
                    { matrix[maxIndex - i][maxIndex - j], matrix[maxIndex - j][i] }
                };
                matrix[j][maxIndex - i] = numbers[0, 0];
                matrix[maxIndex - i][maxIndex - j] = numbers[0, 1];
                matrix[maxIndex - j][i] = numbers[1, 0];
                matrix[i][j] = numbers[1, 1];
            }
        }
    }
}