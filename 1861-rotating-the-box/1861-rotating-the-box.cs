public class Solution {
    public char[][] RotateTheBox(char[][] boxGrid) {
        int m = boxGrid.Length, n = boxGrid[0].Length;
        var result = new char[n][];

        for (int i = 0; i < n; i++) {
            result[i] = new char[m];
            Array.Fill(result[i], '.');
        }

        for (int i = 0; i < m; i++) {
            var end = n - 1;

            for (int j = n - 1; j >= 0; j--) {
                if (boxGrid[i][j] == '#') result[end--][m - i - 1] = '#';
                else if (boxGrid[i][j] == '*') {
                    result[j][m - i - 1] = '*';
                    end = j - 1;
                }
            }
        }

        return result;
    }
}