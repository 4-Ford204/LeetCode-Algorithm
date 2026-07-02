public class Solution {
    public bool FindSafeWalk(IList<IList<int>> grid, int health) {
        int m = grid.Count, n = grid[0].Count;
        var heap = new PriorityQueue<(int R, int C, int H), int>();
        var visited = new HashSet<(int, int)>();
        var directions = new int[][] { new[] {0, 1}, new[] {0, -1}, new[] {1, 0}, new[] {-1, 0} };

        int startDamage = grid[0][0];
        heap.Enqueue((0, 0, startDamage), startDamage);
        visited.Add((0, 0));

        while (heap.Count > 0) {
            var (R, C, H) = heap.Dequeue();

            if (H >= health) continue;
            if (R == m - 1 && C == n - 1) return true;

            foreach (var direction in directions) {
                int nextR = R + direction[0];
                int nextC = C + direction[1];

                if (nextR >= 0 && nextR < m && nextC >= 0 && nextC < n) {
                    if (visited.Contains((nextR, nextC))) continue;

                    int nextH = H + grid[nextR][nextC];
                    if (nextH >= health) continue;

                    visited.Add((nextR, nextC));
                    heap.Enqueue((nextR, nextC, nextH), nextH);
                }
            }
        }

        return false;
    }
}