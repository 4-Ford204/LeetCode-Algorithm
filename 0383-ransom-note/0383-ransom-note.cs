public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Span<int> freq = stackalloc int[26];

        for (int i = 0; i < magazine.Length; i++) freq[magazine[i] - 'a']++;

        for (int i = 0; i < ransomNote.Length; i++) {
            if (--freq[ransomNote[i] - 'a'] < 0) return false;
        }

        return true;
    }
}