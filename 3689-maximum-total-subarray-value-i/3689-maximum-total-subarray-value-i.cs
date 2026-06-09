public class Solution {
    public long MaxTotalValue(int[] nums, int k) {
        int min = int.MaxValue, max = int.MinValue;

        foreach (int num in nums) {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        return (long)(max - min) * k;
    }
}