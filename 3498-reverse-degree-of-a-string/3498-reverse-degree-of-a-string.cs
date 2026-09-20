public class Solution {
    public int ReverseDegree(string s) {
        int result = 0;

        for (int i = 0; i < s.Length; i++)
            result += (26 - (s[i] - 'a')) * (i + 1);

        return result;
    }
}