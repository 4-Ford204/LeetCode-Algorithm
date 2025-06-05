public class Solution {
    public string SmallestEquivalentString(string s1, string s2, string baseStr) {
        char[] map = new char[26];
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < map.Length; i++)
            map[i] = (char)('a' + i);

        for (int i = 0; i < s1.Length; i++) {
            char min = map[s1[i] - 'a'];
            char max = map[s2[i] - 'a'];

            if (min > max) (min, max) = (max, min);

            for (int j = 0; j < map.Length; j++)
                if (map[j] == max) map[j] = min;
        }

        foreach (var character in baseStr)
            builder.Append(map[character - 'a']);

        return builder.ToString();
    }
}