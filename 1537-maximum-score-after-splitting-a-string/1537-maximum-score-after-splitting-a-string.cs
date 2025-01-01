public class Solution {
    public int MaxScore(string s) {
        int n = s.Length, result = 0;
        int[] zeroLeft = new int[n];
        int[] oneRight = new int[n];

        for (int i = 0, j = n - 1; i < n - 1 && j > 0; i++, j--) {
            zeroLeft[i] = zeroLeft[Math.Max(0, i - 1)] + (s[i] == '0' ? 1 : 0);
            oneRight[j] = oneRight[Math.Min(n - 1, j + 1)] + (s[j] == '1' ? 1 : 0);
            
            if (i >= j - 1) {
                result = Math.Max(
                    result,
                    Math.Max(
                        zeroLeft[i] + oneRight[i + 1],
                        zeroLeft[j - 1] + oneRight[j]
                    )
                );
            }
        }

        return result;
    }
}