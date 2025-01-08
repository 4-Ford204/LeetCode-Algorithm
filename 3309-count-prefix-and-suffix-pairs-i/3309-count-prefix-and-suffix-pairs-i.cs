public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int n = words.Length, result = 0;

        for (int i = 0; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++)
                result += IsPrefixAndSuffix(words[i], words[j]) ? 1 : 0;
        }

        return result;
    }

    private bool IsPrefixAndSuffix(string str1, string str2) {
        int n1 = str1.Length, n2 = str2.Length;
        return n1 > n2 ? false : (str1.Equals(str2[..n1]) && str1.Equals(str2[^n1..]));
    }  
}