public class Solution {
    public char[][] RotateTheBox(char[][] box) {
        int m = box.Length;
        int n = box[0].Length;
        char[][] result = new char[n][];

        char[] fill = new char[m];
        Array.Fill(fill, '.');
        for (int i = 0; i < n; i++) {
            result[i] = new char[m];
            fill.CopyTo(result[i], 0);
        }

        for (int i = 0; i < m; i++) {
            int next = n - 1;

            for (int j = n - 1; j >= 0; j--) {
                if (box[i][j] == '#') {
                    result[next][m - 1 - i] = '#';
                    next--;
                } else if (box[i][j] == '*') {
                    result[j][m - 1 - i] = '*';
                    next = j - 1;
                }
            }
        }

        return result;
    }
}