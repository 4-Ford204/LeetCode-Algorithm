public class Solution {
    public int FindGCD(int[] nums) {
        int n = nums.Length;
        int min = int.MaxValue, max = int.MinValue;

        foreach (var num in nums) {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        while (max != 0) (min, max) = (max, min % max);
        
        return min;
    }
}