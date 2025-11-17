public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        int previous = -(k + 1);
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                if (i - previous - 1 < k) return false;
                previous = i;
            }
        }

        return true;
    }
}