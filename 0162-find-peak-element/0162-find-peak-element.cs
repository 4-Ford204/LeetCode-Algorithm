public class Solution {
    public int FindPeakElement(int[] nums) {
        int length = nums.Length;
        int peakElement = -1;

        if (length == 1 || nums[0] > nums[1])
            return 0;
        else if (nums[length - 1] > nums[length - 2]) 
            return length - 1;
        else {
            int left = 1;
            int right = length - 2;

            while (left <= right) {
                int middle = left + (right - left) / 2;

                if (nums[middle - 1] > nums[middle]) {
                    right = middle - 1;
                } else if (nums[middle + 1] > nums[middle]) {
                    left = middle + 1;
                } else {
                    peakElement = middle;
                    break;
                }
            }
        }

        return peakElement;
    }
}