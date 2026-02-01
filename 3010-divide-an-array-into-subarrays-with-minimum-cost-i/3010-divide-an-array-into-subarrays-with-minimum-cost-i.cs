public class Solution {
    public int MinimumCost(int[] nums) {
        int a = int.MaxValue, b = int.MaxValue;

        for (int i = 1; i < nums.Length; i++) {
            var n = nums[i];

            if (n < b) (a, b) = (b, n);
            else if (n < a) a = n;
        }

        return nums[0] + a + b;
    }
}