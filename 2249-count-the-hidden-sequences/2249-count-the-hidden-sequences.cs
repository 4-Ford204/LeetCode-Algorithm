public class Solution {
    public int NumberOfArrays(int[] differences, int lower, int upper) {
        long prefix = 0, min = 0, max = 0;

        foreach (var difference in differences) {
            prefix += difference;
            min = Math.Min(min, prefix);
            max = Math.Max(max, prefix);
        }

        long left = lower - min;
        long right = upper - max;
        return (int)Math.Max(0, right - left + 1);
    }
}