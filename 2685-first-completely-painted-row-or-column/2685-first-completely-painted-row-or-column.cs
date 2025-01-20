public class Solution {
    public int FirstCompleteIndex(int[] arr, int[][] mat) {
        int m = mat.Length, n = mat[0].Length;
        int[,] position = new int[m * n + 1, 2];
        int[] paintedRows = new int[m], paintedColumns = new int[n];

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                int index = mat[i][j];
                position[index, 0] = i;
                position[index, 1] = j;
            }
        }

        for (int i = 0; i < arr.Length; i++) {
            int rowIndex = position[arr[i], 0], columnIndex = position[arr[i], 1];

            if (++paintedRows[rowIndex] == n || ++paintedColumns[columnIndex] == m) 
                return i;
        }

        return -1;
    }
}