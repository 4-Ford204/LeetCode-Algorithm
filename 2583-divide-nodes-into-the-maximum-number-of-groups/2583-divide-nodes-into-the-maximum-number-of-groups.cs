public class Solution {
    public int MagnificentSets(int n, int[][] edges) {
        List<int>[] adjacentList = new List<int>[n];
        int[] colors = new int[n], distances = new int[n];
        bool[] visited = new bool[n];
        int result = 0;

        for (int i = 0; i < n; i++) adjacentList[i] = new List<int>();

        foreach (var edge in edges) {
            adjacentList[edge[0] - 1].Add(edge[1] - 1);
            adjacentList[edge[1] - 1].Add(edge[0] - 1);
        }

        Array.Fill(colors, -1);

        for (int vertice =  0; vertice < n; vertice++) {
            if (colors[vertice] != -1) continue;
            else {
                colors[vertice] = 0;

                if (!IsBipartite(adjacentList, vertice, colors)) return -1;
            }
        }

        for (int vertice = 0; vertice < n; vertice++)
            distances[vertice] = GetLongestShortestPath(adjacentList, vertice, n);

        for (int vertice = 0; vertice < n; vertice++) {
            if (visited[vertice]) continue;
            else result += GetMaximumGroup(adjacentList, vertice, distances, visited);
        }

        return result;
    }

    private bool IsBipartite(List<int>[] adjacentList, int vertice, int[] colors) {
        foreach (var neighbor in adjacentList[vertice]) {
            if (colors[neighbor] == colors[vertice]) return false;
            if (colors[neighbor] != - 1) continue;

            colors[neighbor] = (colors[vertice] + 1) % 2;

            if (!IsBipartite(adjacentList, neighbor, colors)) return false;
        }

        return true;
    }

    private int GetLongestShortestPath(List<int>[] adjacentList, int vertice, int n) {
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[n];
        int distance = 0;

        queue.Enqueue(vertice);
        visited[vertice] = true;

        while (queue.Count > 0) {
            int queueVerticeNumber = queue.Count;

            for (int i = 0; i < queueVerticeNumber; i++) {
                int currentVertice = queue.Dequeue();

                foreach (var neighbor in adjacentList[currentVertice]) {
                    if (visited[neighbor]) continue;
                    else {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }

            distance++;
        }

        return distance;
    }

    private int GetMaximumGroup(List<int>[] adjacentList, int vertice, int[] distances, bool[] visited) {
        int maximumGroup = distances[vertice];
        visited[vertice] = true;
        
        foreach (var neighbor in adjacentList[vertice]) {
            if (visited[neighbor]) continue;
            else 
                maximumGroup = Math.Max(
                    maximumGroup, 
                    GetMaximumGroup(adjacentList, neighbor, distances, visited)
                );
        }

        return maximumGroup;
    }
}