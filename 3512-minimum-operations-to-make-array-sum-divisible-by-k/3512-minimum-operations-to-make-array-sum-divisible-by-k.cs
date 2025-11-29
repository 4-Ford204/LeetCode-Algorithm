public class Solution {
    public int MinOperations(int[] nums, int k) {
        int result = 0;

        foreach (var num in nums) result += num;

        return result % k;
    }
}