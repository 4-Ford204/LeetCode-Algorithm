public class Solution {
    public bool CanPartitionGrid(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        var sum = 0L;
        var hsum = new long[m];
        var vsum = new long[n];

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                var num = grid[i][j];
                sum += num;
                hsum[i] += num;
                vsum[j] += num;
            }
        }

        if ((sum & 1) == 1) return false;
        
        var target = sum / 2;
        sum = 0L;

        for (int i = 0; i < m; i++) {
            sum += hsum[i];
            if (sum > target) break;
            if (sum == target) return true;
        }

        sum = 0L;

        for (int i = 0; i < n; i++) {
            sum += vsum[i];
            if (sum > target) break;
            if (sum == target) return true;
        }

        return false;
    }
}