public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        return Math.Min(
            FinishTime(landStartTime, landDuration, waterStartTime, waterDuration),
            FinishTime(waterStartTime, waterDuration, landStartTime, landDuration)
        );
    }

    private int FinishTime(int[] start1, int[] duration1, int[] start2, int[] duration2) {
        int finish1 = int.MaxValue, finish2 = int.MaxValue;

        for (int i = 0; i < start1.Length; i++)
            finish1 = Math.Min(finish1, start1[i] + duration1[i]);
        
        for (int i = 0; i < start2.Length; i++)
            finish2 = Math.Min(finish2, Math.Max(start2[i], finish1) + duration2[i]);
        
        return finish2;
    }
}