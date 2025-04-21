public class Solution {
    public int NumberOfArrays(int[] differences, int lower, int upper) {
        long prefixDiff = 0, minDiff = 0, maxDiff = 0;

        foreach (var difference in differences) {
            prefixDiff += difference;
            minDiff = Math.Min(minDiff, prefixDiff);
            maxDiff = Math.Max(maxDiff, prefixDiff);
        }

        return (int)Math.Max(0, (upper - lower) - (maxDiff - minDiff) + 1);
    }
}