public class Solution {
    public int MinimumOperations(int[] nums) {
        int result = 0;

        foreach (var num in nums) {
            if (num % 3 != 0) result++;
        }

        return result;
    }
}