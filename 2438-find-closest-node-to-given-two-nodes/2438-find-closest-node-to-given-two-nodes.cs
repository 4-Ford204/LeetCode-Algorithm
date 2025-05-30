public class Solution {
    public int ClosestMeetingNode(int[] edges, int node1, int node2) {
        int n = edges.Length, result = -1, currentMinDistance = int.MaxValue;
        int[] distance1 = new int[n], distance2 = new int[n];
        bool[] visited1 = new bool[n], visited2 = new bool[n];
        Array.Fill(distance1, int.MaxValue);
        Array.Fill(distance2, int.MaxValue);
        distance1[node1] = 0;
        distance2[node2] = 0;

        DFS(node1, edges, distance1, visited1);
        DFS(node2, edges, distance2, visited2);

        for (int current = 0; current < n; current++) {
            if (currentMinDistance > Math.Max(distance1[current], distance2[current])) {
                result = current;
                currentMinDistance = Math.Max(distance1[current], distance2[current]);
            }
        }

        return result;
    }

    private void DFS(int node, int[] edges, int[] distance, bool[] visited) {
        visited[node] = true;
        int neighbor = edges[node];

        if (neighbor != -1 && !visited[neighbor]) {
            distance[neighbor] = distance[node] + 1;
            DFS(neighbor, edges, distance, visited);
        }
    }
}