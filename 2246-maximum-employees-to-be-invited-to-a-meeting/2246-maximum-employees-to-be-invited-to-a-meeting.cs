public class Solution {
    public int MaximumInvitations(int[] favorite) {
        int n = favorite.Length, longestCycle = 0, twoCycleInvitations = 0;
        int[] inDegree = new int[n], depth = new int[n];
        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < n; i++) inDegree[favorite[i]]++;

        for (int i = 0; i < n; i++) if (inDegree[i] == 0) queue.Enqueue(i);

        Array.Fill(depth, 1);

        while (queue.Count > 0) {
            int current = queue.Dequeue();
            int next = favorite[current];
            depth[next] = Math.Max(depth[next], depth[current] + 1);

            if (--inDegree[next] == 0) queue.Enqueue(next);
        }

        for (int i = 0; i < n; i++) {
            int cycleLength = 0, current = i;

            if (inDegree[i] == 0) continue;

            while (inDegree[current] != 0) {
                inDegree[current] = 0;
                cycleLength++;
                current = favorite[current];
            }

            if (cycleLength == 2) twoCycleInvitations += depth[i] + depth[favorite[i]];
            else longestCycle = Math.Max(longestCycle, cycleLength);
        }

        return Math.Max(longestCycle, twoCycleInvitations);
    }
}