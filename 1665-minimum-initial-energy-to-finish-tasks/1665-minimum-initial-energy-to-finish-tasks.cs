public class Solution {
    public int MinimumEffort(int[][] tasks) {
        int result = 0;
        Array.Sort(tasks, (a ,b) => (a[1] - a[0]).CompareTo(b[1] - b[0]));

        foreach (var task in tasks) result = Math.Max(result + task[0], task[1]);

        return result;
    }
}