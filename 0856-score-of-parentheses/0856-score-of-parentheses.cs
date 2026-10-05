public class Solution {
    public int ScoreOfParentheses(string s) {
        int current = 0, result = 0;
        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') current++;
            else {
                current--;
                if (s[i - 1] == '(') result += 1 << current;
            }
        }

        return result;
    }
}