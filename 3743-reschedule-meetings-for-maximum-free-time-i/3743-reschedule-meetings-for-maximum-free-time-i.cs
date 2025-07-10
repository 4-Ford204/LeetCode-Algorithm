public class Solution {
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime) {
        int n = startTime.Length, result = 0;
        int[] prefix = new int[n + 1];

        for (int i = 0; i < n; i++) prefix[i + 1] = prefix[i] + endTime[i] - startTime[i];
        
        for (int i = k - 1; i < n; i++) {
            int left = i == k - 1 ? 0 : endTime[i - k];
            int right = i == n - 1 ? eventTime : startTime[i + 1];
            result = Math.Max(result, right - left - (prefix[i + 1] - prefix[i - k + 1]));
        }

        return result;
    }
}