public class Solution {
    public string MapWordWeights(string[] words, int[] weights) {
        var result = new StringBuilder(words.Length);

        foreach (string word in words) {
            int sum = 0;
            foreach (char character in word) sum += weights[character - 'a'];
            result.Append((char)('z' - sum % 26));
        }

        return result.ToString();
    }
}