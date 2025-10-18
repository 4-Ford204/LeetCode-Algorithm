public class Solution {
    public int MaxDistinctElements(int[] nums, int k) {
        Array.Sort(nums);
        int previous = int.MinValue, result = 0;
        
        foreach (var num in nums) {
            int current = Math.Min(
                Math.Max(num - k, previous + 1),
                num + k
            );

            if (current > previous) {
                result++;
                previous = current;
            }
        }

        return result;
    }
}