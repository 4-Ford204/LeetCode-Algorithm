public class Solution {
    public bool[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries) {
        int m = queries.Length, count = 0;
        var arr = new int[n];
        var answer = new bool[m];

        arr[0] = count;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] - nums[i - 1] > maxDiff) count++;
            arr[i] = count;
        }

        for (int i = 0; i < m; i++)
            answer[i] = arr[queries[i][0]] == arr[queries[i][1]];

        return answer;
    }
}
