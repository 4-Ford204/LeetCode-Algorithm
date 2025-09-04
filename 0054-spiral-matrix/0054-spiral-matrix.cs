public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length, count = 0;
        int up = 0, down = m - 1, left = 0, right = n - 1;
        int[] result = new int[m * n];
        string direction = "right";
        var sign = new Dictionary<string, string>() {
            { "right", "down" },
            { "down", "left" },
            { "left", "up" },
            { "up", "right" }
        };

        while (count < m * n) {
            if (direction.Equals("right")) {
                for (int i = left; i <= right; i++) result[count++] = matrix[up][i];
                up++;
            }
            else if (direction.Equals("down")) {
                for (int i = up; i <= down; i++) result[count++] = matrix[i][right];
                right--;
            }
            else if (direction.Equals("left")) {
                for (int i = right; i >= left; i--) result[count++] = matrix[down][i];
                down--;
            }
            else if (direction.Equals("up")) {
                for (int i = down; i >= up; i--) result[count++] = matrix[i][left];
                left++;
            }

            direction = sign[direction];
        }

        return result;
    }
}