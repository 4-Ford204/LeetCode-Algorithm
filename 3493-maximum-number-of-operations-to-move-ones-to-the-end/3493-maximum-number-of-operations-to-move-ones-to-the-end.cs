public class Solution {
    public int MaxOperations(string s) {
        int n = s.Length, ones = 0, result = 0;

        for (int i = 0; i < n; i++) {
            if (s[i] == '1') ones++;
            else {
                result += ones;
                while (i + 1 < n && s[i + 1] == '0') i++;
            }
        }

        return result;
    }
}