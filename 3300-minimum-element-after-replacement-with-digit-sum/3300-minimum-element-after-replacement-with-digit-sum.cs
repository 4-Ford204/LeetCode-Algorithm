public class Solution {
    public int MinElement(int[] nums) {
        int result = int.MaxValue;

        for (int i = 0; i < nums.Length; i++) {
            int num  = nums[i], sum = 0;

            while (num > 0) {
                sum += num % 10;
                num /= 10;
            }

            if (sum < result) result = sum;
        }

        return result;
    }
}