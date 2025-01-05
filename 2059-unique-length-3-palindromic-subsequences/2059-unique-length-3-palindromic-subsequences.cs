public class Solution {
    public int CountPalindromicSubsequence(string s) {
        int n = s.Length, result = 0, current = 0;
        int[] sBitmask = new int[n], overlap = new int[26];
        sBitmask[0] = 0;

        for (int i = 1; i < n; i++)
            sBitmask[i] = sBitmask[i - 1] | (1 << (s[i - 1] - 'a'));

        for (int i = n - 2; i > 0; i--)
        {
            current |= (1 << (s[i + 1] - 'a'));
            overlap[s[i] - 'a'] |= sBitmask[i] & current;
        }

        for (int i = 0; i < 26; i++)
            result += CountBits(overlap[i], 0);
        
        return result;
    }

    private int CountBits(int number, int count)
    {
        if (number > 0) return CountBits(number >> 1, count + (number & 1));
        else return count;
    }
}