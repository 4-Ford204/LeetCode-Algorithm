public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double result = 0;
        for (int i = 0; i < k; i++) result += nums[i];
        
        double tracking = result;
        for (int i = k; i < nums.Length; i++) {
            tracking += nums[i] - nums[i - k];
            result = Math.Max(result, tracking);
        }
        
        return result / k;
    }
}