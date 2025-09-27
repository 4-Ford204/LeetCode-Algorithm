public class Solution {
    public double LargestTriangleArea(int[][] points) {
        int n = points.Length;
        double result = 0;
        
        for (int i = 0; i < n - 2; i++) {
            for (int j = i + 1; j < n - 1; j++) {
                for (int k = j + 1; k < n; k++) {
                    result = Math.Max(
                        result,
                        Math.Abs(
                            points[i][0] * (points[j][1] - points[k][1]) +
                            points[j][0] * (points[k][1] - points[i][1]) +
                            points[k][0] * (points[i][1] - points[j][1])
                        ) / 2.0
                    );
                }
            }
        }

        return result;
    }
}