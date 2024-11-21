public class Solution {
    public string ReverseVowels(string s) {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        int start = 0;
        int end = s.Length - 1;
        StringBuilder result = new StringBuilder(s);

        while (start < end) {
            if (vowels.Contains(Char.ToLower(s[start])) && vowels.Contains(Char.ToLower(s[end]))) {
                var temp = result[start];
                result[start] = result[end];
                result[end] = temp;

                start++;
                end--;
            }
            else if (vowels.Contains(Char.ToLower(s[start]))) end--;
            else start++;
        }

        return result.ToString();
    }
}