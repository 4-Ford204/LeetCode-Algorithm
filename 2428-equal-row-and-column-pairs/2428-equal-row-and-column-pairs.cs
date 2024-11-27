public class Solution {
    public int EqualPairs(int[][] grid) {
        int equalPairs = 0;
        int n = grid.Length;
        Dictionary<int, int> hashRows = new Dictionary<int, int>();

        for (int i = 0; i < n; i++) {
            HashCode hash = new HashCode();

            for (int j = 0; j < n; j++) 
                hash.Add(grid[i][j]);
 
            int hashCode = hash.ToHashCode();
            if (hashRows.ContainsKey(hashCode)) hashRows[hashCode]++;
            else hashRows.Add(hashCode, 1);
        }

        for (int i = 0; i < n; i++) {
            HashCode hash = new HashCode();

            for (int j = 0; j < n; j++) 
                hash.Add(grid[j][i]);
 
            int hashCode = hash.ToHashCode();
            if (hashRows.TryGetValue(hashCode, out var value)) equalPairs += value;
        }

        return equalPairs;
    }
}