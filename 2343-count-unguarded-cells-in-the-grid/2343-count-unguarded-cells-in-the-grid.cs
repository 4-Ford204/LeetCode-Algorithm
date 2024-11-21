public class Solution {
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls) {
        int[,] matrix = new int[m, n];

        foreach (var wall in walls) matrix[wall[0], wall[1]] = -1;
        foreach (var guard in guards) matrix[guard[0], guard[1]] = -1;

        foreach (var guard in guards) {
            for (int i = guard[0] - 1; i >= 0; i--)
                if (matrix[i, guard[1]] == -1) break;
                else matrix[i, guard[1]] = 1;
            for (int i = guard[1] + 1; i < n; i++)
                if (matrix[guard[0], i] == -1) break;
                else matrix[guard[0], i] = 1;
            for (int i = guard[0] + 1; i < m; i++)
                if (matrix[i, guard[1]] == -1) break;
                else matrix[i, guard[1]] = 1;
            for (int i = guard[1] - 1; i >= 0; i--)
                if (matrix[guard[0], i] == -1) break;
                else matrix[guard[0], i] = 1;
        }

        int count = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (matrix[i, j] == 0) count++;
            }
        }

        return count;
    }
}