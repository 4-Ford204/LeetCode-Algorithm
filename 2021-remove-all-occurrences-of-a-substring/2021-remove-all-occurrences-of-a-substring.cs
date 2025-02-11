public class Solution {
    public string RemoveOccurrences(string s, string part) {
        int index = 0;

        while ((index = s.IndexOf(part, StringComparison.Ordinal)) != -1)
            s = s[..index] + s[(index +  part.Length)..];
        
        return s;
    }
}