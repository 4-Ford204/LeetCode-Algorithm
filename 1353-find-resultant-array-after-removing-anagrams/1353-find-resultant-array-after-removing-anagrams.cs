public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
        int n = words.Length;
        var result = new List<string>();
        result.Add(words[0]);

        for (int i = 1; i < n; i++) {
            if (!IsAnagram(words[i - 1], words[i]))
                result.Add(words[i]);
        }

        return result;
    }

    private bool IsAnagram(string previous, string current) {
        int[] freq = new int[26];

        foreach (var letter in previous) freq[letter - 'a']++;

        foreach (var letter in current) freq[letter - 'a']--;

        foreach (int item in freq) {
            if (item != 0) return false;
        }

        return true;
    }
}