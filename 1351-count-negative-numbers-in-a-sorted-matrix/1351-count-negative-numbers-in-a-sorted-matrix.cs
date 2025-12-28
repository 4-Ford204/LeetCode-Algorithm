public class Solution {
    public int CountNegatives(int[][] grid) {
        int j = grid[0].Length - 1, current = 0, result = 0;

        for (int i = 0; i < grid.Length; i++) {
            for (; j >= 0; j--) {
                if (grid[i][j] >= 0) break;
                current++;
            }

            result += current;
        }

        return result;
    }
}