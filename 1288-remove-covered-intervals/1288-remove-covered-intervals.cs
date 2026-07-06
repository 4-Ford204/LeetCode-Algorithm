public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        int n = intervals.Length, previous = 0, result = n;
        Array.Sort(intervals, (a, b) => {
            return a[0] == b[0] ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0]);
        });

        for (int i = 0; i < n; i++) {
            int current = intervals[i][1];

            if (current <= previous) result--;
            else previous = current;
        }

        return result;
    }
}