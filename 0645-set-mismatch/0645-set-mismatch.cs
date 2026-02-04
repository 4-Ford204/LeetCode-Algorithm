public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int n = nums.Length;
        var result = new int[2];

        for (int i = 0; i < n; i++) {
            var num =  Math.Abs(nums[i]);
            var index = num - 1;
            var value = nums[index];

            if (value < 0) result[0] = num;
            else nums[index] = -nums[index]; 
        }

        for (int i = 0; i < n; i++) {
            if (nums[i] > 0) result[1] = i + 1;
        }

        return result;
    }
}