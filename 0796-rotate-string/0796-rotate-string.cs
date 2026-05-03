public class Solution {
    public bool RotateString(string s, string goal) {
        if (s == goal) return true;

        for (int i = 1; i < s.Length; i++) {
            if (s.Substring(i) + s.Substring(0, i) == goal)
                return true;
        }

        return false;
    }
}