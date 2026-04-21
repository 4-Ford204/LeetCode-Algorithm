public class Solution {
    public string SmallestSubsequence(string s) {
        int n = s.Length;
        var seenIndex = new int[26];
        var used = new bool[26];
        var stack = new Stack<char>();

        for (int i = 0; i < n; i++) seenIndex[s[i] - 'a'] = i;

        for (int i = 0; i < n; i++) {
            if (used[s[i] - 'a']) continue;

            while (stack.Count > 0 && stack.Peek() > s[i] && seenIndex[stack.Peek() - 'a'] > i)
                used[stack.Pop() - 'a'] = false;

            stack.Push(s[i]);
            used[s[i] - 'a'] = true;
        }

        return new String(stack.Reverse().ToArray());
    }
}