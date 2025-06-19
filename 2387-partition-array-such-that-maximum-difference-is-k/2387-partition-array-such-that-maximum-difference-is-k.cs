public class Solution {
    public int PartitionArray(int[] nums, int k) {
        Array.Sort(nums);
        int min = nums[0], result = 0;

        for (int i = 1; i < nums.Length; i++) {
            int num = nums[i];

            if (num - min > k) {
                min = num;
                result++;
            }
        }

        return result + 1;
    }
}