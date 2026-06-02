public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        int result = int.MaxValue;

        for (int i = 0; i < landStartTime.Length; i++) {
            for (int j = 0; j < waterStartTime.Length; j++) {
                var land_water = Math.Max(landStartTime[i] + landDuration[i], waterStartTime[j]) + waterDuration[j];
                var water_land = Math.Max(waterStartTime[j] + waterDuration[j], landStartTime[i]) + landDuration[i];
                result = Math.Min(result, Math.Min(land_water, water_land));
            }
        }

        return result;
    }
}