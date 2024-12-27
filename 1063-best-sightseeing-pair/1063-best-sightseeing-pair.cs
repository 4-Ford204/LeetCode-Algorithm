public class Solution {
    public int MaxScoreSightseeingPair(int[] values) {
        int result = int.MinValue;
        int previousMaxSpot = values[0];

        for (int i = 1; i < values.Length; i++) {
            result = Math.Max(result, previousMaxSpot + values[i] - i);
            previousMaxSpot = Math.Max(previousMaxSpot, values[i] + i);
        }

        return result;
    }
}