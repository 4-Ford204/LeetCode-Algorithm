public class Solution {
    public int CountPartitions(int[] nums) {
        int n = nums.Length, sum = 0;

        for (int i = 0; i < n; i++) sum += nums[i];

        return sum % 2 == 0 ? n - 1 : 0;
    }
}