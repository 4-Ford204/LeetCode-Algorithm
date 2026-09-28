public class Solution {
    public int MaxDepth(string s) {
        int count = 0, result = 0;

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') count++;
            if (s[i] == ')') count--;

            result = Math.Max(result, count);
        }

        return result;
    }
}