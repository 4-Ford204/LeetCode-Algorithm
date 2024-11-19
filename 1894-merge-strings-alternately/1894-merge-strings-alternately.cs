public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int length1 = word1.Length;
        int length2 = word2.Length;
        int maxLength = Math.Max(length1, length2);
        var result = new StringBuilder();

        for (int i = 0; i < maxLength; i++) {
            if (i < length1)
                result.Append(word1[i]);
            
            if (i < length2)
                result.Append(word2[i]);
        }

        return result.ToString();
    }
}