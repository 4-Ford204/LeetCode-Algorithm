public class Solution {
    public int NumberOfSubstrings(string s) {
        int n = s.Length, left = 0, right = 0, result = 0;
        int[] frequency = new int[3];

        while (right < n) {
            frequency[s[right] - 'a']++;

            while (frequency[0] > 0 && frequency[1] > 0 && frequency[2] > 0) {
                result += n - right;
                frequency[s[left++] - 'a']--;
            }

            right++;
        }

        return result;
    }
}