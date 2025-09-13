public class Solution {
    public int MaxFreqSum(string s) {
        int[] freq = new int[26];
        int vowel = 0, consonant = 0;

        foreach (var character in s) {
            int index = character - 'a';
            freq[index]++;

            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                vowel = Math.Max(vowel, freq[index]);
            else
                consonant = Math.Max(consonant, freq[index]);
        }

        return vowel + consonant;
    }
}