public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int start = 0, end = n - 1;

        while (start <= end) {
            int mid = start + (end - start) / 2;

            if (nums[mid] >= nums[end]) start = mid + 1;
            else end = mid;
        }

        return nums[end];
    }
}