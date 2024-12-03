public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        char[] result = new char[s.Length + spaces.Length];
        int i = 0, j = 0, k = 0;

        for (; i < s.Length; i++) {
            if (j < spaces.Length && i == spaces[j]) {
                result[k++] = ' ';
                j++;
            }
      
            result[k++] = s[i];            
        }

        return new String(result);
    }
}