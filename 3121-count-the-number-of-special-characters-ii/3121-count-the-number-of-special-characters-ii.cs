public class Solution {
    public int NumberOfSpecialChars(string word) {
        int result = 0;
        var arr = new int[26][];

        for (int i = 0; i < 26; i++) {
            arr[i] = new int[2];
            arr[i][0] = -1;
            arr[i][1] = -1;
        }

        for (int i = 0; i < word.Length; i++) {
            var character = word[i];

            if (character >= 'a' && character <= 'z')
                arr[character - 'a'][0] = i;
            else if (arr[character - 'A'][1] == -1)
                arr[character - 'A'][1] = i;
        }

        for (int i = 0; i < 26; i++) {
            if (arr[i][0] != -1 && arr[i][1] != -1 && arr[i][0] < arr[i][1])
                result++;
        } 

        return result;
    }
}