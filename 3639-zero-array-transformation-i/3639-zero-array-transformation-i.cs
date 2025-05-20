public class Solution {
    public bool IsZeroArray(int[] nums, int[][] queries) {
        int n = nums.Length, prefix = 0;
        int[] diffArray = new int[n + 1];

        foreach (var query in queries) {
            diffArray[query[0]]++;
            diffArray[query[1] + 1]--;
        }

        for (int i = 0; i < n; i++) {
            prefix += diffArray[i];
            if (nums[i] > prefix) return false;
        }

        return true;
    }
}