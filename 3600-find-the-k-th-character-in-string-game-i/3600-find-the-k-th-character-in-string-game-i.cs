public class Solution {
    public char KthCharacter(int k) {
        return "abbcbccdbccdcddebccdcddecddedeefbccdcddecddedeefcddedeefdeefeffgbccdcddecddedeefcddedeefdeefeffgcddedeefdeefeffgdeefeffgeffgfgghbccdcddecddedeefcddedeefdeefeffgcddedeefdeefeffgdeefeffgeffgfgghcddedeefdeefeffgdeefeffgeffgfgghdeefeffgeffgfggheffgfgghfgghghhibccdcddecddedeefcddedeefdeefeffgcddedeefdeefeffgdeefeffgeffgfgghcddedeefdeefeffgdeefeffgeffgfgghdeefeffgeffgfggheffgfgghfgghghhicddedeefdeefeffgdeefeffgeffgfgghdeefeffgeffgfggheffgfgghfgghghhideefeffgeffgfggheffgfgghfgghghhieffgfgghfgghghhifgghghhighhihiij"[k - 1];
    }

    private char BruteForce(int k) {
        string current = "a";

        while (k > current.Length) {
            var currentBuilder = new StringBuilder();

            foreach (var item in current)
                currentBuilder.Append((char)((item - 'a' + 1) % 26 + 'a'));

            current += currentBuilder.ToString();
        }

        return current[k - 1];
    }
}