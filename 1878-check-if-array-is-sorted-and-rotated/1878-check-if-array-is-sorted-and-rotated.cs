public class Solution {
    public bool Check(int[] nums) {
        int n = nums.Length, increasing = 0;

        for (int i = 0; i < n - 1; i++) if (nums[i] > nums[i + 1]) increasing++;

        if (nums[n - 1] > nums[0]) increasing++;

        return increasing <= 1;
    }
}