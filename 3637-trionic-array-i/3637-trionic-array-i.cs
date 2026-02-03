public class Solution {
    public bool IsTrionic(int[] nums) {
        int n = nums.Length, group = 1;

        if (n < 4) return false;

        for (int i = 0; i < n - 1; i++) {
            if (group == 1) {
                if (nums[i] < nums[i + 1]) continue;
                else if (i > 0 && nums[i] > nums[i + 1]) group++;
                else return false;
            }
            else if (group == 2) {
                if (nums[i] > nums[i + 1]) continue;
                else if (nums[i] < nums[i + 1]) group++;
                else return false;
            }
            else if (group == 3) {
                if (nums[i] >= nums[i + 1]) return false;
            }
        }

        return group == 3;
    }
}
