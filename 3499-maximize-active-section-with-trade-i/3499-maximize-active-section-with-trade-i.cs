public class Solution {
    public int MaxActiveSectionsAfterTrade(string s) {
        int n = s.Length, ones = 0;

        foreach (var character in s) {
            if (character == '1') ones++;
        }

        int i = 0, zeros = 0;
        int previous = int.MinValue, current = 0;

        while (i < n) {
            int start = i;
            
            while (i < n && s[i] == s[start]) i++;

            if (s[start] == '0') {
                current = i - start;
                if (previous != int.MinValue) zeros = Math.Max(zeros, previous + current);
                previous = current;
            }
        }
        
        return ones + zeros;
    }
}