public class Solution {
    public int CountHillValley(int[] nums) {
        int result = 0;

        for (int i = 0, j = 1; j < nums.Length - 1; j++) {
            if (nums[j] == nums[j + 1]) continue;
            
            if ((nums[j] < nums[i] && nums[j] < nums[j + 1]) ||
                (nums[j] > nums[i] && nums[j] > nums[j + 1]))
                result++;
                
            i = j;
        }

        return result;
    }
}