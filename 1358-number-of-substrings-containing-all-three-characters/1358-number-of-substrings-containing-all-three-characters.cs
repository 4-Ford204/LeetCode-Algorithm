public class Solution {
    public int NumberOfSubstrings(string s) {
        int n = s.Length;
        int a = -1, b = -1, c = -1;
        int result = 0;

        for (int i = 0; i < n; i++) {
            switch (s[i]) {
                case 'a': a = i; break;
                case 'b': b = i; break;
                case 'c': c = i; break;
            }

            if (a != -1 && b != -1 && c != -1)
                result += Math.Min(Math.Min(a, b), c) + 1;
        }

        return result;
    }
}