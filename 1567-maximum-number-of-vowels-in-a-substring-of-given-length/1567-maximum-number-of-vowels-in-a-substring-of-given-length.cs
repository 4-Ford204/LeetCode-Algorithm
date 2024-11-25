public class Solution {
    public int MaxVowels(string s, int k) {
        int[] vowels = new int[26];
        vowels['a' - 'a'] = 1;
        vowels['e' - 'a'] = 1;
        vowels['i' - 'a'] = 1;
        vowels['o' - 'a'] = 1;
        vowels['u' - 'a'] = 1;

        int tracking = 0;
        for (int i = 0; i < k; i++)
            tracking += vowels[s[i] - 'a'];

        int max = tracking;
        for (int i = k; i < s.Length; i++) {
            tracking += vowels[s[i] - 'a'] - vowels[s[i - k] - 'a'];
            max = Math.Max(max, tracking);
        }

        return max;
    }
}