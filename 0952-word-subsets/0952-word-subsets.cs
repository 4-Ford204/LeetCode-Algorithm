public class Solution {
    public IList<string> WordSubsets(string[] words1, string[] words2) {
        int[] chars = new int[26];
        List<string> result = new List<string>();

        foreach (var word in words2) {
            int[] subchars = new int[26];

            foreach (var character in word) {
                int index = character - 'a';
                subchars[index]++;
                chars[index] = Math.Max(chars[index], subchars[index]);
            }
        }

        foreach (var word in words1) {
            int[] subchars = new int[26];
            bool isUniversal = true;

            foreach (var character in word) subchars[character - 'a']++;
            for (int i = 0; i < 26; i++) {
                if (chars[i] > subchars[i]) {
                    isUniversal = false;
                    break;
                }
            }

            if (isUniversal) result.Add(word);
        }

        return result;
    }
}