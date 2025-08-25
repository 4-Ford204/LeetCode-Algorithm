public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;

        int n = s.Length, nextColumn = (numRows - 1) * 2, index = 0;
        Span<char> result = stackalloc char[n];

        for (int i = 0; i < numRows; i++) {
            int increment = i * 2;

            for (int j = i; j < n; j += increment) {
                result[index++] = s[j];

                if (increment != nextColumn)
                    increment = nextColumn - increment;
            }
        }

        return result.ToString();
    }
}