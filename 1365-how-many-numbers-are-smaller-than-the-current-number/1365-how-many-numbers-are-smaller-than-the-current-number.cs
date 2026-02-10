public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int n = nums.Length;
        var result = new int[n];

        for (int i = 0; i < n; i++) {
            int current = nums[i], count = 0;

            for (int j = 0; j < n; j++) {
                if (current > nums[j]) count++;
            }

            result[i] = count;
        }

        return result;
    }
}