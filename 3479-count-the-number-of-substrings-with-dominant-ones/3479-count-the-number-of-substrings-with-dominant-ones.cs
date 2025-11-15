public class Solution {
    public int NumberOfSubstrings(string s) {
        int n = s.Length, result = 0;
        var previous = new int[n + 1];
        previous[0] = -1;

        for (int i = 0; i < n; i++)
            previous[i + 1] = (i == 0 || (i > 0 && s[i - 1] == '0')) ? i : previous[i];

        for (int i = 1; i <= n; i++) {
            int j = i, zeros = s[i - 1] == '0' ? 1 : 0;

            while (j > 0 && zeros * zeros <= n) {
                int ones = (i - previous[j]) - zeros;

                if (zeros * zeros <= ones)
                    result += Math.Min(j - previous[j], ones - zeros * zeros + 1);
                
                j = previous[j];
                zeros++;
            }
        }

        return result;
    }
}