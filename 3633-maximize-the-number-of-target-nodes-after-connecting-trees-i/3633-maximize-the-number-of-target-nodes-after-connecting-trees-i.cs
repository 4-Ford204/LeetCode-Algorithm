public class Solution {
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k) {
        int n = edges1.Length + 1;
        int[] result = new int[n];
        int[] nodeTarget1 = BuildTarget(edges1, k);
        int maxNodeTarget2 = BuildTarget(edges2, k - 1).Max();

        for (int i = 0; i < n; i++)
            result[i] = nodeTarget1[i] + maxNodeTarget2;

        return result;
    }

    private int[] BuildTarget(int[][] edges, int k) {
        int n = edges.Length + 1;
        List<int>[] graph = new List<int>[n];
        int[] result = new int[n];

        for (int i = 0; i < n; i++) graph[i] = new List<int>();

        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        for (int i = 0; i < n; i++) result[i] = DFS(i, -1, graph, k);

        return result;
    }

    private int DFS(int current, int previous, List<int>[] graph, int k) {
        if (k >= 0) {
            int result = 1;

            foreach (var node in graph[current]) {
                if (node == previous) continue;
                result += DFS(node, current, graph, k - 1);
            }

            return result;
        }

        return 0;
    }
}