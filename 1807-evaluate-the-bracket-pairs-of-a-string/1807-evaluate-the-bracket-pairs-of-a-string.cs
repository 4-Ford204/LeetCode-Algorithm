public class Solution {
    public string Evaluate(string s, IList<IList<string>> knowledge) {
        var map = new Dictionary<string, string>();
        var result = new StringBuilder();

        foreach (var item in knowledge) map[item[0]] = item[1];
        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                int j = s.IndexOf(')', i);
                string key = s.Substring(i + 1, j - i - 1);

                result.Append(
                    map.TryGetValue(key, out var value) ? value : "?"
                );
                
                i = j;
            }
            else result.Append(s[i]);
        }

        return result.ToString();
    }
}