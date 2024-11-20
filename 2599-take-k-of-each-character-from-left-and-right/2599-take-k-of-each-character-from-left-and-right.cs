public class Solution {
    public int TakeCharacters(string s, int k) {
        int[] frequency = new int[3];

        if (k == 0) return 0;
        if (!IsPossible(s, k, frequency)) return -1;

        int n = s.Length;
        int[] slidingWindow = new int[3];
        int maxLength = 0;
        int left = 0;

        for (int right = 0; right < n; right++) {
            slidingWindow[s[right] - 'a']++;

            while (left <= right && !IsValid(frequency, slidingWindow, k)) {
                slidingWindow[s[left] - 'a']--;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }
        
        return n - maxLength;
    }

    private bool IsPossible(string s, int k, int[] frequency) {
        foreach (var i in s) frequency[i - 'a']++;

        foreach (var count in frequency) {
            if (count < k) return false;
        }

        return true;
    }

    private bool IsValid(int[] frequency, int[] slidingWindow, int k) {
        for (int i = 0; i < 3; i++) {
            if (frequency[i] - slidingWindow[i] < k) return false;
        }

        return true;
    }
}