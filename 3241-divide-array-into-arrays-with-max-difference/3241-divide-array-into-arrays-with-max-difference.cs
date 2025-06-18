public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);
        int n = nums.Length;
        int[][] result = new int[n / 3][];

        for (int i = 0; i < n; i += 3) {
            int first = nums[i];
            int second = nums[i + 1];
            int third = nums[i + 2];

            if (third - first <= k)
                result[i / 3] = new int[] { first, second, third };
            else
                return new int[0][];
        }

        return result;
    }
}