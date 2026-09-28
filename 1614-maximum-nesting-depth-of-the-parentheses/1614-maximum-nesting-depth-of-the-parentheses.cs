public class Solution {
    public int MaxDepth(string s) {
        int count = 0, result = 0;

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') result = Math.Max(result, ++count);
            else if (s[i] == ')') count--;        
        }

        return result;
    }
}