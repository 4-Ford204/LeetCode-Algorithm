public class Solution {
    public int MinMoves(int[] nums) {
        int max = nums[0], result = 0;

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];

            if (num > max) {
                result += (num - max) * i;
                max = num;
            }
            else result += max - num;
        }

        return result;
    }
}