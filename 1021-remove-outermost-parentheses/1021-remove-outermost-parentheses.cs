public class Solution {
    public string RemoveOuterParentheses(string s) {
        int current = 0;
        var result = new StringBuilder();

        for (int start = 0, end = 0; end < s.Length; end++) {
            current += s[end] == '(' ? 1 : -1;

            if (current == 0) {
                result.Append(s.Substring(start + 1, end - start - 1));
                start = end + 1;
            }
        }

        return result.ToString();
    }
}