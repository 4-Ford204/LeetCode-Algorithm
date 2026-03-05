public class Solution {
    public int MinOperations(string s) {
        int change = 0;

        for (int i = 0; i < s.Length; i++) {
            change += (s[i] == '0' + (i % 2)) ? 1 : 0;
        }

        return Math.Min(change, s.Length - change);
    }
}