public class Solution {
    public int NumSub(string s) {
        int modulo = 1_000_000_007;
        int n = s.Length, ones = 0, result = 0;

        for (int i = 0; i < n; i++) {
            if (s[i] == '0')
                ones = 0;
            else
                result = (result + ++ones) % modulo;
        }

        return result;
    }
}