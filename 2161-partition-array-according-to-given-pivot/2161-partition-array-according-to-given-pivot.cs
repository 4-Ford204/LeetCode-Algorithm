public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int n = nums.Length, start = 0, end = n - 1;
        var result = new int[n];

        for (int i = 0, j = n - 1; i < n && j >= 0; i++, j--) {
            if (nums[i] < pivot) result[start++] = nums[i];
            if (nums[j] > pivot) result[end--] = nums[j];
        }

        while (start <= end) result[start++] = pivot;

        return result;
    }
}