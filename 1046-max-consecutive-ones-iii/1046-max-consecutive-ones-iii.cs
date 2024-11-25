public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int zeroTracking = 0;
        int startTracking = 0;
        int max = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) 
                zeroTracking++;

            while (zeroTracking > k) {
                if (nums[startTracking] == 0) zeroTracking--;
                startTracking++;
            }

            max = Math.Max(max, i - startTracking + 1);
        }

        return max;
    }
}