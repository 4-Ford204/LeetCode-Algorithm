public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        int i = 0, j = nums.Length - 1, result = 0;

        while (i < j) result = Math.Max(result, nums[i++] + nums[j--]);
        
        return result;
    }
}