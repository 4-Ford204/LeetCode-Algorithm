public class Solution {
    public int LengthAfterTransformations(string s, int t) {
        int[] freq = new int[26];
        int modulo = 1_000_000_007, result = 0;

        foreach (var character in s) freq[character - 'a']++;

        while (t-- > 0) {
            int next = freq[0];

            for (int i = 1; i <= 25; i++) (freq[i], next) = (next, freq[i]);
            
            freq[0] = next;
            freq[1] = (freq[1] + next) % modulo;
        }

        for (int i = 0; i <= 25; i++) result = (result + freq[i]) % modulo;

        return result;
    }
}