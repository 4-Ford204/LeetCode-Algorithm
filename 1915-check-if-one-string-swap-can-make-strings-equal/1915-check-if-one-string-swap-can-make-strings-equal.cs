public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        int n = s1.Length, equal = 0;
        char char1 = ' ', char2 = ' ';

        for (int i = 0; i < n; i++) {
            if (s1[i] == s2[i]) equal++;
            else {
                if (char1 != ' ') {
                    if (char1 != s2[i] || char2 != s1[i]) 
                        return false;
                } else {
                    char1 = s1[i];
                    char2 = s2[i];
                }
            }
        }

        return equal == n || equal == n - 2;
    }
}