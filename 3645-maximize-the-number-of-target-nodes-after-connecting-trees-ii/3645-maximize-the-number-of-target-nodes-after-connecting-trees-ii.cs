public class Solution {
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2) {
        int n = edges1.Length + 1, m = edges2.Length + 1;
        int[] color1 = new int[n];
        int[] color2 = new int[m];
        int[] nodeTarget1 = BuildTarget(edges1, color1);
        int[] nodeTarget2 = BuildTarget(edges2, color2);
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
            result[i] += nodeTarget1[color1[i]] + Math.Max(nodeTarget2[0], nodeTarget2[1]);

        return result;
    }

    private int[] BuildTarget(int[][] edges, int[] color) {
        int n = edges.Length + 1;
        List<int>[] graph = new List<int>[n];

        for (int i = 0; i < n; i++) graph[i] = new List<int>();

        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        int result = DFS(0, -1, 0, graph, color);

        return new int[] { result, n - result };
    }

    private int DFS(int current, int previous, int path, List<int>[] graph, int[] color) {
        int result = 1 - path % 2;
        color[current] = path % 2;

        foreach (var node in graph[current]) {
            if (node == previous) continue;
            result += DFS(node, current, path + 1, graph, color);
        }

        return result;
    }
}