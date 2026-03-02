public class Solution {
    public int MinSwaps(int[][] grid) {
        int n = grid.Length, result = 0;
        var position = new int[n];
        Array.Fill(position, -1);

        for (int i = 0; i < n; i++) {
            for (int j = n - 1; j >= 0; j--) {
                if (grid[i][j] == 1) {
                    position[i] = j;
                    break;
                }
            }
        }

        for (int i = 0; i < n; i++) {
            int match = -1;

            for (int j = i; j < n; j++) {
                if (position[j] <= i) {
                    result += j - i;
                    match = j;
                    break;
                }
            }

            if (match == -1) return - 1;

            for (int j = match; j > i; j--) (position[j], position[j - 1]) = (position[j - 1], position[i]);
        }

        return result;
    }
}