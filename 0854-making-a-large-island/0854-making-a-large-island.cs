public class Solution {
    public int LargestIsland(int[][] grid) {
        int n = grid.Length, islandId = 2, result = 1;
        Dictionary<int, int> islands = new Dictionary<int, int>();

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1) 
                    islands.Add(islandId, ExploreIsland(grid, islandId++, i, j, n));
            }
        }

        if (islands.Count == 0) return 1;
        if (islands.Count == 1)
            return islands[--islandId] == n * n ? islands[islandId] : islands[islandId] + 1;
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 0) {
                    int size = 1;
                    HashSet<int> neighbors = new HashSet<int>();

                    if (i + 1 < n && grid[i + 1][j] > 1) neighbors.Add(grid[i + 1][j]);
                    if (i - 1 >= 0 && grid[i - 1][j] > 1) neighbors.Add(grid[i - 1][j]);
                    if (j + 1 < n && grid[i][j + 1] > 1) neighbors.Add(grid[i][j + 1]);
                    if (j - 1 >= 0 && grid[i][j - 1] > 1) neighbors.Add(grid[i][j - 1]);

                    foreach (var id in neighbors) size += islands[id];

                    result = Math.Max(result, size);
                }
            }
        }

        return result;
    }

    private int ExploreIsland(int[][] grid, int islandId, int row, int column, int n) {
        if (row < 0 || row >= n || column < 0 || column >= n || grid[row][column] != 1)
            return 0;
        else {
            grid[row][column] = islandId;

            return 1 +
                ExploreIsland(grid, islandId, row + 1, column, n) +
                ExploreIsland(grid, islandId, row - 1, column, n) +
                ExploreIsland(grid, islandId, row, column + 1, n) +
                ExploreIsland(grid, islandId, row, column - 1, n);
        } 
    }
}