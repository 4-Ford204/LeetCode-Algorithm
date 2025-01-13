public class Solution {
    public int MinimumLength(string s) {
        int[] chars = new int[26];
        int result = 0;

        foreach (var character in s) chars[character - 'a']++;

        foreach (var frequency in chars) {
            if (frequency == 0) continue;
            else result += frequency % 2 == 0 ? 2 : 1;
        } 

        return result;
    }
}