public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        int n = words.Length, longest = 1, longestIndex = 0;
        int[] dp = new int[n], previous = new int[n];
        List<string> result = new List<string>();

        for (int i = 0; i < n; i++) {
            dp[i] = 1;
            previous[i] = -1;
        }

        for (int i = 1; i < n; i++) {
            int currentLongest = 1;
            int currentLongestIndex = -1;

            for (int j = i - 1; j >= 0; j--) {
                if (groups[i] != groups[j] && dp[j] + 1 > currentLongest) {
                    currentLongest = dp[j] + 1;
                    currentLongestIndex = j;
                }
            }

            dp[i] = currentLongest;
            previous[i] = currentLongestIndex;

            if (dp[i] > longest) {
                longest = dp[i];
                longestIndex = i;
            }
        }

        for (int i = longestIndex; i != -1; i = previous[i]) result.Add(words[i]);
        
        result.Reverse();
        return result;
    }
}