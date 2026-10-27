public class Solution {
    public string[] CreateGrid(int m, int n) {
        var result = new string[m];
        var unique = string.Concat(".", new string('#', n - 1));

        for (int i = 0; i < m - 1; i++) result[i] = unique;

        result[m - 1] = new string('.', n);

        return result;
    }
}