public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int result = 0;

        for (int i = 0; i < points.Length - 1; i++) {
            result += Math.Max(
                Math.Abs(points[i][0] - points[i + 1][0]),
                Math.Abs(points[i][1] - points[i + 1][1])
            );
        }

        return result;
    }
}