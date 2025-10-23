public class Solution {
    public bool HasSameDigits(string s) {
        int n = s.Length;
        char[] digit = s.ToCharArray();

        for (int i = 1; i < n - 1; i++) {
            for (int j = 0; j < n - i; j++) {
                digit[j] = (char)(
                    ((digit[j] - '0') + (digit[j + 1])) % 10 + '0'
                );
            }
        }

        return digit[0] == digit[1];
    }
}