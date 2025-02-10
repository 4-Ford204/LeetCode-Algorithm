public class Solution {
    public string ClearDigits(string s) {
        StringBuilder builder = new StringBuilder(s);

        for (int i = 0; i < builder.Length; i++) {
            if (char.IsDigit(builder[i])) {
                if (i > 0) builder.Remove(i-- - 1, 1);
                builder.Remove(i--, 1);
            }
        }

        return builder.ToString();
    }
}