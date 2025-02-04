public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        int n = edges.Length;
        int[] parent = new int[n + 1];
        int[] rank = new int[n + 1];

        for (int i = 1; i <= n; i++) {
            parent[i] = i;
            rank[i] = 1;
        }

        foreach (var edge in edges) {
            var (a, b) = (edge[0], edge[1]);

            if (!Union(a, b, parent, rank)) return edge;
        }

        return new int[2];
    }

    private bool Union(int a, int b, int[] parent, int[] rank) {
        int rootA = Find(a, parent);
        int rootB = Find(b, parent);

        if (rootA == rootB) return false;

        if (rank[rootA] > rank[rootB]) parent[rootB] = rootA;
        else if (rank[rootA] < rank[rootB]) parent[rootA] = rootB;
        else {
            parent[rootB] = rootA;
            rank[rootA]++;
        }

        return true;
    }

    private int Find(int node, int[] parent) {
        if (parent[node] != node) parent[node] = Find(parent[node], parent);

        return parent[node];
    }
}