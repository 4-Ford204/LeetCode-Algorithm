public class Solution {
    public int MinMoves(int[] nums) {
        int min = nums[0];
        var sum = 0L;

        foreach (var num in nums) {
            min = Math.Min(min, num);
            sum += num;
        }

        return (int)(sum - min * nums.Length);
    }
}