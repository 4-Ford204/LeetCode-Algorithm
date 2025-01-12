public class Solution {
    public bool CanBeValid(string s, string locked) {
        int length = s.Length;
        Stack<int> unlocked = new Stack<int>();
        Stack<int> openBrackets = new Stack<int>();

        if (length % 2 == 1) return false;

        for (int i = 0; i < length; i++) {
            if (locked[i] == '0') unlocked.Push(i);
            else if (s[i] == '(') openBrackets.Push(i);
            else if (s[i] == ')') {
                if (openBrackets.Count != 0) openBrackets.Pop();
                else if (unlocked.Count != 0) unlocked.Pop();
                else return false;
            }
        }

        while (
            unlocked.Count != 0 &&
            openBrackets.Count != 0 &&
            openBrackets.Peek() < unlocked.Peek()
        ) {
            unlocked.Pop();
            openBrackets.Pop();
        }

        return openBrackets.Count == 0;
    }
}