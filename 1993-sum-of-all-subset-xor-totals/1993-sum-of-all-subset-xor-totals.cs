public class Solution {
    public int SubsetXORSum(int[] nums) {
        int result = 0;

        foreach (var num in nums) result |= num;

        return result << (nums.Length - 1);
    }
}