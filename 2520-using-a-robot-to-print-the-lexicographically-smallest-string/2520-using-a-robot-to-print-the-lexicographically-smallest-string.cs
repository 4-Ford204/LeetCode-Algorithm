public class Solution {
    public string RobotWithString(string s) {
        int[] freq = new int[26];
        Stack<char> t = new Stack<char>();
        StringBuilder builder = new StringBuilder();
        char min = 'a';

        foreach (var character in s) freq[character - 'a']++;

        foreach (var character in s) {
            freq[character - 'a']--;
            t.Push(character);

            while (min != 'z' && freq[min - 'a'] == 0) min++;

            while (t.Count > 0 && t.Peek() <= min) builder.Append(t.Pop());
        }

        return builder.ToString();
    }
}