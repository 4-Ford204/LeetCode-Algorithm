public class Solution {
    public int MaximumBeauty(int[] nums, int k) {
        int start = 0, end = 0, result = 0;    
        Array.Sort(nums);

        for (end = 0; end < nums.Length; end++) {
            while (nums[start] + k < nums[end] - k) 
                start++;

            result = Math.Max(result, end - start + 1);
        }

        return result;
    }
}