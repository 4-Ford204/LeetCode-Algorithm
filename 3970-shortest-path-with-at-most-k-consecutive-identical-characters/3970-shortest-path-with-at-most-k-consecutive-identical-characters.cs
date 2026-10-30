public class Solution {
    public int ShortestPath(int n, int[][] edges, string labels, int k) {
        var graph = new List<(int v, int w)>[n];
        var distance = new long[n, k + 1];
        var heap = new PriorityQueue<(long d, int u, int count), long>();

        for (int i = 0; i < n; i++) graph[i] = new List<(int, int)>();

        foreach (var edge in edges) graph[edge[0]].Add((edge[1], edge[2]));
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j <= k; j++) distance[i, j] = int.MaxValue;
        }

        distance[0, 1] = 0;
        heap.Enqueue((0, 0, 1), 0);

        while (heap.Count > 0) {
            var (d, u, count) = heap.Dequeue();

            if (d > distance[u, count]) continue;
            if (u == n - 1) return (int)d;

            foreach (var (v, w) in graph[u]) {
                int nextCount = labels[u] == labels[v] ? count + 1 : 1;
                var nextDistance = d + w;

                if (nextCount > k) continue;

                if (nextDistance < distance[v, nextCount]) {
                    distance[v, nextCount] = nextDistance;
                    heap.Enqueue((nextDistance, v, nextCount), nextDistance);
                }
            }
        }

        return -1;
    }
}