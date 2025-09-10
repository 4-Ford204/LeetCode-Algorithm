public class Solution {
    public int MinimumTeachings(int n, int[][] languages, int[][] friendships) {
        var people = new HashSet<int>();
        var freq = new Dictionary<int, int>();
        int max = 0;

        foreach (var friendship in friendships) {
            int u = friendship[0] - 1, v = friendship[1] - 1;
            var hashset = new HashSet<int>();

            foreach (var lang in languages[u]) hashset.Add(lang);
            foreach (var lang in languages[v]) hashset.Add(lang);

            if (hashset.Count == languages[u].Length + languages[v].Length) {
                people.Add(u);
                people.Add(v);
            }
        }

        foreach (var person in people) {
            foreach (var lang in languages[person]) {
                if (!freq.ContainsKey(lang)) freq[lang] = 0;
                
                freq[lang]++;
                max = Math.Max(max, freq[lang]);
            }
        }

        return people.Count - max;
    }
}