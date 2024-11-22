public class Solution {
    public void MoveZeroes(int[] nums) {
        for (int i = 0, j = 0; i < nums.Length; i++) {
            if (nums[i] == 0) j++;
            else {
                if (j == 0) continue;

                nums[i - j] = nums[i];
                nums[i] = 0;
            }
        }
    }
}