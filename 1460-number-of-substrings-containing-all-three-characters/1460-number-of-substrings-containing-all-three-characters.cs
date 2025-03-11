public class Solution {
    public int NumberOfSubstrings(string s) {
        int[] position = new int[3] { -1, -1, -1 };
        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            position[s[i] - 'a'] = i;
            result += 1 + position.Min();
        }

        return result;
    }

    private int SlidingWindow(string s) {
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