public class Solution {
    public int CountDays(int days, int[][] meetings) {
        int tracking = 0, result = 0;
        Array.Sort(meetings, (x, y) => { return x[0] - y[0]; });

        foreach (var meeting in meetings) {
            int start = meeting[0], end = meeting[1];
            
            if (start > tracking + 1) 
                result += start - tracking - 1;

            tracking = Math.Max(tracking, end);
        }

        result += days - tracking;
        return result;
    }
}