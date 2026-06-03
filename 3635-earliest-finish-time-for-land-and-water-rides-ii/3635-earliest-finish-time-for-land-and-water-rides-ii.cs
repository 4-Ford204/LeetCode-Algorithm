public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        int land = Finish(landStartTime, landDuration, 0);
        int water = Finish(waterStartTime, waterDuration, 0);
        int land_water = Finish(waterStartTime, waterDuration, land);
        int water_land = Finish(landStartTime, landDuration, water);
        
        return Math.Min(land_water, water_land);
    }

    private int Finish(int[] start, int[] duration, int end) {
        int finish = int.MaxValue;

        for (int i = 0; i < start.Length; i++) {
            finish = Math.Min(
                finish,
                Math.Max(end, start[i]) + duration[i]
            );
        }
        
        return finish;
    }
}