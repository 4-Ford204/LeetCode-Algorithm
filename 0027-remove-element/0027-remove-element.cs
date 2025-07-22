public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0, j = nums.Length - 1;

        while (j >= 0 && nums[j] == val) j--;

        while (i <= j) {
            if (nums[i] == val) (nums[i], nums[j]) = (nums[j], nums[i]);
            i++;
            while (j >= 0 && nums[j] == val) j--;
        }

        return i;
    }
}