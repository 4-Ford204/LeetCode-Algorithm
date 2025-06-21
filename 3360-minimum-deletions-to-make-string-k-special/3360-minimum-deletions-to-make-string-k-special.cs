public class Solution {
    public int MinimumDeletions(string word, int k) {
        var freq = new Dictionary<char, int>();
        int result = word.Length;

        foreach (var character in word) {
            if (freq.ContainsKey(character))
                freq[character]++;
            else
                freq[character] = 1;
        }

        foreach (int current in freq.Values) {
            int deleted = 0;

            foreach (int iteration in freq.Values) {
                if (current > iteration)
                    deleted += iteration;
                else if (iteration > current + k)
                    deleted += iteration - (current + k);
            }

            result = Math.Min(result, deleted);
        }

        return result;
    }
}