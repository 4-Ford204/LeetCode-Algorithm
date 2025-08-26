public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        int maxDiagonal = 0, result = 0;

        foreach (var dimension in dimensions) {
            var currentDiagonal = dimension[0] * dimension[0] + dimension[1] * dimension[1];
            
            if (currentDiagonal == maxDiagonal)
                result = Math.Max(result, dimension[0] * dimension[1]);

            if (currentDiagonal > maxDiagonal) {
                maxDiagonal = currentDiagonal;
                result = dimension[0] * dimension[1];
            }
        }

        return result;
    }
}