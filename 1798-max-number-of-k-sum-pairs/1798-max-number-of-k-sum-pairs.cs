public class Solution {
    public int MaxOperations(int[] nums, int k) {
        Array.Sort(nums);
        int i = 0;
        int j = nums.Length - 1;
        int operation = 0;

        while (i < j) {
            if (nums[i] + nums[j] == k) {
                operation++;
                i++;
                j--;
            } else if (nums[i] + nums[j] > k) j--;
            else if (nums[i] + nums[j] < k) i++;
        }

        return operation;
    }
}