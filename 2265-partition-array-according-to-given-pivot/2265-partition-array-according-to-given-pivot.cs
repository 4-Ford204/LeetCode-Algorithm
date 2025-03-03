public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int n = nums.Length, left = 0, right = n - 1;
        int[] result = new int[n];

        for (int i = 0, j = n - 1; i < n; i++, j--) {
            if (nums[i] < pivot) result[left++] = nums[i];
            if (nums[j] > pivot) result[right--] = nums[j];
        }

        while (left <= right) result[left++] = pivot;

        return result;
    }
}