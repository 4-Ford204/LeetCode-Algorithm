public class Solution {
    public string SortVowels(string s) {
        string sortedVowels = "AEIOUaeiou";
        var freqVowels = new Dictionary<char, int>();
        var result = new StringBuilder();

        foreach (var vowel in sortedVowels)
            freqVowels[vowel] = 0;

        foreach (var character in s) {
            if (sortedVowels.Contains(character))
                freqVowels[character]++;
        }

        foreach (var character in s) {
            if (!sortedVowels.Contains(character))
                result.Append(character);
            else {
                foreach (var vowel in sortedVowels) {
                    if (freqVowels[vowel]-- > 0) {
                        result.Append(vowel);
                        break;
                    }
                }
            }
        }

        return result.ToString();
    }
}