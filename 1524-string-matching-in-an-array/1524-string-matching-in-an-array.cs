public class Solution {
    public IList<string> StringMatching(string[] words) {
        int n = words.Length;
        List<string> result = new List<string>();
        Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

        for (int i = 0; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++) {
                if (words[j].Contains(words[i])) {
                    result.Add(words[i]);
                    break;
                }
            }
        }

        return result;
    }
}