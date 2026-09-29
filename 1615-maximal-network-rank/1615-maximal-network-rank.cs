public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) {
        int result = 0;
        var count = new int[n];
        var connect = new bool[n, n];

        foreach (var road in roads) {
            count[road[0]]++;
            count[road[1]]++;
            connect[road[0], road[1]] = true;
            connect[road[1], road[0]] = true;
        }

        for (int i = 0; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++)
                result = Math.Max(
                    result,
                    count[i] + count[j] - (connect[i, j] ? 1 : 0)
                );
        }
        
        return result;
    }
}