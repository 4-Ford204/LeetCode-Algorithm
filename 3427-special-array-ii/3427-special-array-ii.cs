public class Solution {
    public bool[] IsArraySpecial(int[] nums, int[][] queries) {
        int[] prefix = new int[nums.Length];
        bool[] result = new bool[queries.Length];

        for (int i = 1; i < nums.Length; i++) {
            if ((nums[i] - nums[i - 1]) % 2 == 0) prefix[i] = prefix[i - 1] + 1;
            else prefix[i] = prefix[i - 1];
        }

        for (int i = 0; i < queries.Length; i++) {
            int start = queries[i][0];
            int end = queries[i][1];

            if (prefix[end] == prefix[start]) result[i] = true;
        }

        return result;
    }
}