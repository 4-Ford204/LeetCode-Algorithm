public class Solution {
    public int LargestOverlap(int[][] img1, int[][] img2) {
        int n = img1.Length, result = 0;
        var count = new int [n * 2, n * 2];

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (img1[i][j] == 0) continue;

                for (int h = 0; h < n; h++) {
                    for (int k = 0; k < n; k++) {
                        if (img2[h][k] == 0) continue;

                        result = Math.Max(
                            result,
                            ++count[n + i - h, n + j - k]
                        );
                    }
                }
            }
        }

        return result;
    }
}