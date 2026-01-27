public class Solution {
    public int MinCost(int n, int[][] edges) {
        var graph = new List<(int node, int weight)>[n];
        var heap = new PriorityQueue<(int distance, int node), int>();
        var visited = new bool[n];
        var distance = new int[n];

        heap.Enqueue((0, 0), 0);

        Array.Fill(distance, int.MaxValue);
        distance[0] = 0;

        for (int i = 0; i < n; i++) graph[i] = new List<(int, int)>();

        foreach (var edge in edges) {
            var (u, v, w) = (edge[0], edge[1], edge[2]);
            graph[u].Add((v, w));
            graph[v].Add((u, w * 2));
        }

        while (heap.Count > 0) {
            var (currentDistance, u) = heap.Dequeue();

            if (u == n - 1) return currentDistance;
            if (visited[u]) continue;

            visited[u] = true;

            foreach (var neighbor in graph[u]) {
                var (v, w) = (neighbor.node, neighbor.weight);
                var nextDistance = currentDistance + w;

                if (nextDistance < distance[v]) {
                    distance[v] = nextDistance;
                    heap.Enqueue((nextDistance, v), nextDistance);
                }
            }
        }
        
        return -1;
    }
}