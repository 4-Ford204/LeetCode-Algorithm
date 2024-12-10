public class Solution {
    public int[] ConstructTransformedArray(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
            result[i] = nums[((i + nums[i]) % n + n) % n];

        return result;
    }
}