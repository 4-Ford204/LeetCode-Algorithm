public class Solution {
    public int[] QueryResults(int limit, int[][] queries) {
        int n = queries.Length;
        Dictionary<int, int> balls = new Dictionary<int, int>();
        Dictionary<int, int> colors = new Dictionary<int, int>();
        int[] result = new int[n];

        for (int i = 0; i < n; i++) {
            int ball = queries[i][0];
            int color = queries[i][1];
            
            if (balls.ContainsKey(ball)) {
                if (--colors[balls[ball]] == 0) colors.Remove(balls[ball]);
            }
            
            balls[ball] = color;

            if (colors.ContainsKey(color)) colors[color]++;
            else colors[color] = 1;

            result[i] = colors.Count;
        }

        return result;
    }
}