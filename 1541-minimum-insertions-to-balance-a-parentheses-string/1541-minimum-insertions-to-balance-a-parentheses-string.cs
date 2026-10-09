public class Solution {
    public int MinInsertions(string s) {
        int open = 0, result = 0;
        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') open++;
            else {
                if (i + 1 < s.Length && s[i + 1] == ')') i++;
                else result++;

                if (open > 0) open--;
                else result++;
            }
        }

        return open * 2 + result;
    }
}