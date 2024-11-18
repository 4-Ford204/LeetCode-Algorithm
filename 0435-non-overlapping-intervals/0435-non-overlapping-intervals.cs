public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1]));
        int count = 0;
        int end = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++) {
            if (intervals[i][0] < end) count++;
            else end = intervals[i][1];
        }

        return count;
    }
}