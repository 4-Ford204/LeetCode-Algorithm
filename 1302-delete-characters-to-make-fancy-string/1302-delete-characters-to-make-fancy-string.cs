public class Solution {
    public string MakeFancyString(string s) {
        if (s.Length < 3) return s;
        
        var builder = new StringBuilder();
        builder.Append(s[0]);
        builder.Append(s[1]);

        for (int i = 2; i < s.Length; i++) {
            if (!s[i].Equals(s[i - 1]) || !s[i].Equals(s[i - 2]))
                builder.Append(s[i]);
        }

        return builder.ToString();
    }
}