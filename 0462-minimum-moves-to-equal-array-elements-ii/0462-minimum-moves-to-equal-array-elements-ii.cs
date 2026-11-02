public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        int mid = nums[nums.Length / 2], result = 0;

        foreach (var num in nums) result += Math.Abs(num - mid);
        
        return result;
    }
}