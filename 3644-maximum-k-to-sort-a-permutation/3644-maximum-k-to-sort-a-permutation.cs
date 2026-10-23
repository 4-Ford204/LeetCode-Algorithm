public class Solution {
    public int SortPermutation(int[] nums) {
        int n = nums.Length, result = int.MaxValue;
        
        for (int i = 0; i < n; i++) {
            if (nums[i] != i) result &= nums[i];
        }

        return result == int.MaxValue ? 0 : result;
    }
}