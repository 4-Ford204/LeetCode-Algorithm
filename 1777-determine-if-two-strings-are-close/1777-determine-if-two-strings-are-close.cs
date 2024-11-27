public class Solution {
    public bool CloseStrings(string word1, string word2) {
        int[] letters1 = new int[26];
        int[] letters2 = new int[26];

        if (word1.Length != word2.Length) return false;

        for (int i = 0; i < word2.Length; i++) {
            letters1[word1[i] - 'a']++;
            letters2[word2[i] - 'a']++;
        }

        for (int i = 0; i < 26; i++)
            if ((letters1[i] > 0) != (letters2[i] > 0)) return false;

        Array.Sort(letters1);
        Array.Sort(letters2);

        for (int i = 0; i < 26; i++)
            if (letters1[i] != letters2[i]) return false;

        return true;
    }
}