public class Solution {
    public int MaxDistance(string s, int k) {
        int x = 0, y = 0, result = 0;

        for (int i = 0; i < s.Length; i++) {
            switch (s[i]) {
                case 'N': y++; break;
                case 'S': y--; break;
                case 'E': x++; break;
                case 'W': x--; break;
            }

            result = Math.Max(
                result,
                Math.Min(
                    Math.Abs(x) + Math.Abs(y) + 2 * k,
                    i + 1
                )
            );
        }

        return result;
    }
}