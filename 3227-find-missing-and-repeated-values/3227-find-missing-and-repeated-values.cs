public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int n = grid.Length;
        bool[] visited = new bool[n * n + 1];
        int[] result = new int[2];

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                int num = grid[i][j];
                
                if (visited[num]) result[0] = num;
                else visited[num] = true;
            }
        }

        for (int i = 1; i < visited.Length; i++) {
            if (!visited[i]) {
                result[1] = i;
                break;
            }
        }

        return result;
    }
}