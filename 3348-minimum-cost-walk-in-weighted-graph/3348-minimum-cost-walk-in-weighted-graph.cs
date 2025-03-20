using System;

public class Solution {
    private int[] parent;
    private int[] depth;

    public int[] MinimumCost(int n, int[][] edges, int[][] queries) {
        parent = new int[n];
        for (int i = 0; i < n; i++) parent[i] = -1;

        depth = new int[n];

        int[] componentCost = new int[n];
        for (int i = 0; i < n; i++) {
            componentCost[i] = int.MaxValue;
        }

        foreach (var edge in edges) {
            Union(edge[0], edge[1]);
        }

        foreach (var edge in edges) {
            int root = Find(edge[0]);
            componentCost[root] &= edge[2];
        }

        int[] answer = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++) {
            int start = queries[i][0];
            int end = queries[i][1];

            if (Find(start) != Find(end)) {
                answer[i] = -1;
            } else {
                int root = Find(start);
                answer[i] = componentCost[root];
            }
        }
        return answer;
    }

    private int Find(int node) {
        if (parent[node] == -1) return node;
        return parent[node] = Find(parent[node]);
    }

    private void Union(int node1, int node2) {
        int root1 = Find(node1);
        int root2 = Find(node2);

        if (root1 == root2) return;

        if (depth[root1] < depth[root2]) {
            int temp = root1;
            root1 = root2;
            root2 = temp;
        }

        parent[root2] = root1;

        if (depth[root1] == depth[root2]) {
            depth[root1]++;
        }
    }
}
