public class Solution {
    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k) {
        List<int>[] graph = new List<int>[n];
        int result = 0;

        for (int i = 0; i < n; i++) graph[i] = new List<int>();
        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        DFS(graph, values, k, 0, -1, ref result);

        return result;
    }

    private int DFS(List<int>[] graph, int[] values, int k, int current, int previous, ref int result) {
        int total = values[current];

        foreach (var next in graph[current]) {
            if (next != previous)
                total = (total + DFS(graph, values, k, next, current, ref result)) % k;
        }

        result += total % k == 0 ? 1 : 0;

        return total;
    }
}