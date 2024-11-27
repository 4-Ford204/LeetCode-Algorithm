public class Solution {
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries) {
        List<int>[] paths = new List<int>[n];
        int[] dp = new int[n];
        int[] result = new int[queries.Length];

        for (int i = 0; i < n; i++) {
            paths[i] = i + 1 < n ? new List<int>() { i + 1 } : new List<int>();
            dp[i] = i;
        }

        for (int i = 0; i < queries.Length; i++) {
            paths[queries[i][0]].Add(queries[i][1]);

            for (int j = queries[i][0]; j < n; j++) {
                foreach (var next in paths[j])
                    dp[next] = Math.Min(dp[next], dp[j] + 1);
            }

            result[i] = dp[n - 1];
        }

        return result;
    }
}