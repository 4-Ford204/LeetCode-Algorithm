public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        int i = s.Length;

        while (--i >= 0 && s[i] != ' ');

        return s.Length - 1 - i;
    }
}