public class Solution {
    public bool CheckValidString(string s) {
        int min = 0, max = 0;
        
        foreach (var character in s) {
            if (character == '(') { min++; max++; }
            if (character == ')') { min--; max--; }
            if (character == '*') { min--; max++; }
            if (min < 0) min = 0;
            if (max < 0) return false;
        }

        return min == 0;
    }
}