public class Solution {
    public bool IsValid(string s) {
        char[] stack = new char[s.Length];
        int top = -1;

        foreach (char bracket in s) {
            if (bracket == '(')
                stack[++top] =')';
            else if (bracket == '{')
                stack[++top] = '}';
            else if (bracket == '[')
                stack[++top] = ']';
            else {
                if (top == -1 || stack[top--] != bracket)
                    return false;
            }
        }

        return top == -1;
    }
}