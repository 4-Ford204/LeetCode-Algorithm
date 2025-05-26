public class Solution {
    public int LongestPalindrome(string[] words) {
        int[,] visited = new int[26, 26];
        int result = 0;

        foreach (var word in words) {
            var i = word[0] - 'a';
            var j = word[1] - 'a';

            if (visited[j, i] != 0) {
                visited[j, i]--;
                result += 4;
            } else visited[i, j]++;
        }

        for (int i = 0; i < 26; i++) {
            if (visited[i, i] != 0) {
                result += 2;
                break;
            }
        }

        return result;
    }
}