public class Solution {
    public long CountOfSubstrings(string word, int k) {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        int[] nextConsonant = new int[word.Length];
        int n = word.Length, nextConsonantIndex = n, start = 0, end = 0, consonantCount = 0;
        Dictionary<char, int> vowelCount = new Dictionary<char, int>();
        long result = 0;

        for (int i = n - 1; i >= 0; i--) {
            nextConsonant[i] = nextConsonantIndex;
            nextConsonantIndex = !vowels.Contains(word[i]) ? i : nextConsonantIndex;
        }

        while (end < n) {
            char currentLetter = word[end];

            if (vowels.Contains(currentLetter))
                vowelCount[currentLetter] = vowelCount.GetValueOrDefault(currentLetter, 0) + 1;
            else consonantCount++;

            while (consonantCount > k) {
                char startLetter = word[start++];

                if (vowels.Contains(startLetter)) {
                    if (--vowelCount[startLetter] == 0) vowelCount.Remove(startLetter);
                } else consonantCount--;
            }

            while (start < n && vowelCount.Count == vowels.Length && consonantCount == k) {
                result += nextConsonant[end] - end;
                char startLetter = word[start++];

                if (vowels.Contains(startLetter)) {
                    if (--vowelCount[startLetter] == 0) vowelCount.Remove(startLetter);
                } else consonantCount--;
            }

            end++;
        }

        return result;
    }
}