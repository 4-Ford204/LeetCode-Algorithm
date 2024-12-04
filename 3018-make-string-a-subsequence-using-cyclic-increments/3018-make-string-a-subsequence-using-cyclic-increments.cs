public class Solution {
    public bool CanMakeSubsequence(string str1, string str2) {
        int i = 0, j = 0;
        
        while (i < str1.Length && j < str2.Length) {
            var nextChar = str1[i] == 'z' ? 'a' : str1[i] + 1;

            if (str1[i] == str2[j] || nextChar == str2[j]) j++;
            i++;
        }

        return j == str2.Length;
    }
}