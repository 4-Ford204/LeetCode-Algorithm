public class Solution {
    public bool CheckValidCuts(int n, int[][] rectangles) {
        Array.Sort(rectangles, (x, y) => { return x[1] - y[1]; });
        HashSet<int> hashset = new HashSet<int>();
        int tracking = rectangles[0][3];

        for (int i = 0; i < rectangles.Length; i++) {
            if (tracking == n) break;

            if (rectangles[i][1] >= tracking && !hashset.Contains(rectangles[i][1]))
                hashset.Add(rectangles[i][1]);

            tracking = Math.Max(tracking, rectangles[i][3]);
            if (hashset.Count >= 2) break;
        }

        if (hashset.Count >= 2) return true;
        Array.Sort(rectangles, (x, y) => { return x[0] - y[0]; });
        hashset.Clear();
        tracking = rectangles[0][2];

        for (int i = 0; i < rectangles.Length; i++) {
            if (tracking == n) break;

            if (rectangles[i][0] >= tracking && !hashset.Contains(rectangles[i][0]))
                hashset.Add(rectangles[i][0]);

            tracking = Math.Max(tracking, rectangles[i][2]);
            if (hashset.Count >= 2) break;
        }

        return hashset.Count >= 2;
    }
}