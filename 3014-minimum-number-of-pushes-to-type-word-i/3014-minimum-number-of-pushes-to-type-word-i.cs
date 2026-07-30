public class Solution {
    public int MinimumPushes(string word) {
        int result = 0;

        for (int i = 0; i < word.Length; i++)
            result += i / 8 + 1;

        return result;
    }
}