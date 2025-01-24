public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) {
        int n = graph.Length;
        int[] indegree = new int[n];
        List<int>[] adjacency = new List<int>[n];
        Queue<int> queue = new Queue<int>();
        bool[] safe = new bool[n];
        List<int> result = new List<int>();

        for (int i = 0; i < n; i++) adjacency[i] = new List<int>();
        
        for (int i = 0; i < n; i++) {
            foreach (var vertice in graph[i]) {        
                indegree[i]++;
                adjacency[vertice].Add(i);
            }
        }

        for (int i = 0; i < n; i++) if (indegree[i] == 0) queue.Enqueue(i);

        while (queue.Count > 0) {
            int vertice = queue.Dequeue();
            safe[vertice] = true;

            foreach (int neighbor in adjacency[vertice]) if (--indegree[neighbor] == 0) queue.Enqueue(neighbor);
        }

        for (int i = 0; i < n; i++) if (safe[i]) result.Add(i);

        return result;
    }
}
