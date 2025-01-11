public class Solution {
    public bool CanConstruct(string s, int k) {
        int[] chars = new int[26];
        int minPalindrome = 0;

        if (s.Length < k) return false;
        if (s.Length == k) return true;

        foreach (var character in s) chars[character - 'a']++;

        foreach (var number in chars) {
            if (number != 0) 
                if (number % 2 == 1) minPalindrome++;
        }

        return minPalindrome <= k;
    }
}