public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        int count = 0;
        char[] word = new char[k];
        string[] result = new string[(s.Length + k - 1) / k];

        for (int i = 0; i < s.Length; i++) {
            word[count++] = s[i];

            if (count == k) {
                result[i / k] = new string(word);
                count = 0;
            }
        }

        if (count > 0 && count < k) {
            for (int i = k - 1; i >= count; i--) word[i] = fill;
            result[^1] = new string(word);
        }

        return result;
    }
}