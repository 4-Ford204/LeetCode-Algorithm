public class Solution {
    public int MinimumDiameterAfterMerge(int[][] edges1, int[][] edges2) {
        List<int>[] graph1 = GetGraph(edges1);
        List<int>[] graph2 = GetGraph(edges2);
        int diameter1 = GetDiameter(graph1) - 1;
        int diameter2 = GetDiameter(graph2) - 1;
        int mergeDiameter = 1 + (diameter1 + 1) / 2 + (diameter2 + 1) / 2;

        return Math.Max(mergeDiameter, Math.Max(diameter1, diameter2));
    }

    private List<int>[] GetGraph(int[][] edges) {
        int n = edges.Length + 1;
        List<int>[] graph = new List<int>[n];

        for (int i = 0; i < n; i++) graph[i] = new List<int>();

        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        return graph;
    }

    private int GetDiameter(List<int>[] graph) => DFS(graph, DFS(graph, 0, -1)[1], -1)[0];

    private int[] DFS(List<int>[] graph, int node, int previousNode) {
        int maxDepth = 0, farthestNode = node;

        foreach (int nextNode in graph[node]) {
            if (nextNode != previousNode) {
                int[] result = DFS(graph, nextNode, node);
                if (result[0] > maxDepth) (maxDepth, farthestNode) = (result[0], result[1]);
            }
        }

        return new int[] { maxDepth + 1, farthestNode };
    }
}