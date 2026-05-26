public class Solution {
    public int NumberOfSpecialChars(string word) {
        int result = 0;
        var arr = new bool[26, 2];

        foreach (var character in word) {
            if (character >= 'a' && character <= 'z')
                arr[character - 'a', 0] = true;
            else
                arr[character - 'A', 1] = true;
        }

        for (int i = 0; i < 26; i++) {
            if (arr[i, 0] && arr[i, 1]) result++;
        }

        return result;
    }
}