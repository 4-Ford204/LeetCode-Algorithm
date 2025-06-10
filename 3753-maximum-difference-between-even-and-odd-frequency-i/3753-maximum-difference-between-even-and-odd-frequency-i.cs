public class Solution {
    public int MaxDifference(string s) {
        int[] freq = new int[26];
        int odd = 0, even = int.MaxValue;

        foreach (var character in s) freq[character - 'a']++;

        foreach (var charFreq in freq) {
            if (charFreq == 0) continue;
            else if (charFreq % 2 == 1) odd = Math.Max(odd, charFreq);
            else if (charFreq % 2 == 0) even = Math.Min(even, charFreq);
        }

        return odd - even;
    }
}