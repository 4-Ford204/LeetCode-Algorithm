public class Solution {
    public bool DetectCapitalUse(string word) {
        return (char.IsUpper(word[0]) && IsUpper(word)) || IsLower(word);
    }

    public bool IsUpper(string word) {
        for (int i = 1; i < word.Length; i++) {
            if (!char.IsUpper(word[i])) return false;
        }

        return true;
    }

    public bool IsLower(string word) {
        for (int i = 1; i < word.Length; i++) {
            if (!char.IsLower(word[i])) return false;
        }

        return true;
    }
}