public class Solution {
    public int MaximumGain(string s, int x, int y) {
        int result = 0;
        var substrings = new List<(string value, int points)>() { ("ab", x), ("ba", y) };

        if (x < y) (substrings[0], substrings[1]) = (substrings[1], substrings[0]);

        foreach (var substring in substrings) {
            result += RemoveSubstring(substring.value, substring.points, ref s);
        }

        return result;
    }

    private int RemoveSubstring(string substring, int points, ref string s) {
        var builder = new StringBuilder();
        var count = 0;

        for (int i = 0; i < s.Length; i++) {
            if (builder.Length > 0 && builder[^1] == substring[0] && s[i] == substring[1]) {
                builder.Remove(builder.Length - 1, 1);
                count++;
            } else builder.Append(s[i]);
        }

        s = builder.ToString();
        return count * points;
    }
}