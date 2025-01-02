public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        var vowels = new HashSet<char>(new[] { 'a', 'e', 'i', 'o', 'u' });
        int[] prefix = new int[words.Length + 1];
        int[] result = new int[queries.Length];

        for (int i = 0; i < words.Length; i++)
            prefix[i + 1] = prefix[i] +
                ((vowels.Contains(words[i][0]) && vowels.Contains(words[i][^1])) ? 1 : 0);

        for (int i = 0; i < queries.Length; i++) {
            var (left, right) = (queries[i][0], queries[i][1]);
            result[i] = prefix[right + 1] - prefix[left];
        }

        return result;
    }
}