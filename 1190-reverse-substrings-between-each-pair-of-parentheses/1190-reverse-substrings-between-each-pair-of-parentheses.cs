public class Solution {
    public string ReverseParentheses(string s) {
        int n = s.Length;
        var pair = new int[s.Length];
        var stack = new Stack<int>();
        var result = new StringBuilder();

        for (int i = 0; i < n; i++) {
            pair[i] = 0;
            
            if (s[i] == '(') stack.Push(i);
            
            if (s[i] == ')') {
                var j = stack.Pop();
                pair[i] = j;
                pair[j] = i;
            }
        }

        for (int i = 0, j = 1; i < n; i += j) {
            if (s[i] == '(' || s[i] == ')') {
                i = pair[i];
                j = -1 * j;
            }
            else result.Append(s[i]);
        }

        return result.ToString();
    }
}