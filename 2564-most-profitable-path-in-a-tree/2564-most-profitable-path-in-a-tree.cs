public class Solution {
    private List<int>[] Tree;
    private Dictionary<int, int> BobPath;
    private bool[] Visited;

    public int MostProfitablePath(int[][] edges, int bob, int[] amount) {
        int n = amount.Length, maxIncome = int.MinValue;
        Tree = new List<int>[n];
        BobPath = new Dictionary<int, int>();
        Visited = new bool[n];
        Queue<int[]> queue = new Queue<int[]>();

        for (int i = 0; i < n; i++) Tree[i] = new List<int>();

        foreach (var edge in edges) {
            Tree[edge[0]].Add(edge[1]);
            Tree[edge[1]].Add(edge[0]);
        }

        FindBobPath(bob, 0);
        Array.Fill(Visited, false);
        queue.Enqueue(new int[] { 0, 0, 0 });

        while (queue.Count > 0) {
            int[] data = queue.Dequeue();
            int currentNode = data[0], time = data[1], income = data[2];

            if (!BobPath.TryGetValue(currentNode, out var bobTime) || time < bobTime)
                income += amount[currentNode];
            else if (time == bobTime)
                income += amount[currentNode] / 2;

            if (Tree[currentNode].Count == 1 && currentNode != 0)
                maxIncome = Math.Max(maxIncome, income);

            foreach (int nextNode in Tree[currentNode]) {
                if (!Visited[nextNode])
                    queue.Enqueue(new int[] { nextNode, time + 1, income });
            }

            Visited[currentNode] = true; 
        }

        return maxIncome;
    }

    private bool FindBobPath(int currentNode, int time) {
        BobPath.Add(currentNode, time);
        Visited[currentNode] = true;

        if (currentNode == 0) return true;

        foreach (int nextNode in Tree[currentNode]) {
            if (!Visited[nextNode]) {
                if (FindBobPath(nextNode, time + 1)) return true;
            }
        }

        BobPath.Remove(currentNode);
        return false;
    }
}