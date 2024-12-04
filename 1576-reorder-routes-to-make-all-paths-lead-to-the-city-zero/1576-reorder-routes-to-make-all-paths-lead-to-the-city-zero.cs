public class Solution {
    public int MinReorder(int n, int[][] connections) {
        bool[] visited = new bool[n];
        List<(int, bool)>[] graph = new List<(int, bool)>[n];

        for (int i = 0; i < n; i++) 
            graph[i] = new List<(int, bool)>();

        foreach (var connection in connections) {
            graph[connection[0]].Add((connection[1], true));
            graph[connection[1]].Add((connection[0], false));
        }

        return DFS(0, n, visited, graph);
    }

    private int DFS(int current, int n, bool[] visited, List<(int, bool)>[] graph) {
        int result = 0;
        visited[current] = true;

        for (int i = 0; i < graph[current].Count; i++) {
            var (next, direction) = graph[current][i];

            if (!visited[next])
                result += (direction ? 1 : 0) + DFS(next, n, visited, graph);
        }
        
        return result;
    }
}