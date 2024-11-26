public class Solution {
    public int PivotIndex(int[] nums) {
        int total = 0;
        int leftTracking = 0;
        
        for (int i = 0; i < nums.Length; i++)
            total += nums[i];
        
        for (int i = 0; i < nums.Length; i++) {
            if (leftTracking == total - leftTracking - nums[i]) 
                return i;

            leftTracking += nums[i];
        }
        
        return -1;
    }
}