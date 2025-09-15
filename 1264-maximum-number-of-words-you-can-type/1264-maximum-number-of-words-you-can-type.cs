public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        int bitset = 0, result = 0;

        foreach (var letter in brokenLetters) bitset |= 1 << (letter - 'a');

        foreach (var word in text.Split(' ')) {
            bool isBroken = false;

            foreach (var character in word) {
                if ((bitset & (1 << (character - 'a'))) != 0) {
                    isBroken = true;
                    break;
                }
            }

            if (!isBroken) result++;
        }

        return result;
    }

    public int HashSet(string text, string brokenLetters) {
        var hashset = new HashSet<char>();
        int result = 0;

        foreach (var letter in brokenLetters) hashset.Add(letter);

        foreach (var word in text.Split(' ')) {
            bool isBroken = false;

            foreach (var character in word) {
                if (hashset.Contains(character)) {
                    isBroken = true;
                    break;
                }
            }

            if (!isBroken) result++;
        }

        return result;
    }
}