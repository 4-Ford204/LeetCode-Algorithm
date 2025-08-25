public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {
        int m = mat.Length, n = mat[0].Length, direction = 0;
        List<int> current = new List<int>(), result = new List<int>();

        for (int k = 0; k < m + n - 1; k++) {
            int i = k < n ? 0 : k - n + 1;
            int j = k < n ? k : n - 1;
            current.Clear();

            while (i < m && j >= 0) current.Add(mat[i++][j--]);

            if (direction++ % 2 == 0) current.Reverse();
            
            result.AddRange(current);
        }

        return result.ToArray();
    }
}