public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length, destination = n - 1;

        for (int i = n - 1; i >= 0; i--) {
            if (i + nums[i] >= destination) destination = i;
        }

        return destination == 0;
    }
}