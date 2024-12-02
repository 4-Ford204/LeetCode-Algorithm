public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++) {
            if (words[i].Length >= searchWord.Length) {
                bool prefix = true;

                for (int j = 0; j < searchWord.Length; j++) {
                    if (words[i][j] != searchWord[j]) {
                        prefix = false;
                        break;
                    }
                }

                if (prefix) return i + 1;
            }
        }

        return -1;
    }
}