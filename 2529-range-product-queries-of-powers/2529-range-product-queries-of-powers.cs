public class Solution {
    public int[] ProductQueries(int n, int[][] queries) {
        var powers = new List<long>();

        for (int i = 1; n > 0; n >>= 1) {
            if ((n & 1) == 1) powers.Add(i);
            i <<= 1;
        }

        int modulo = 1_000_000_007, m = powers.Count;
        int[,] result = new int[m, m];
        int[] answers = new int[queries.Length];

        for (int i = 0; i < m; i++) {
            long current = 1;

            for (int j = i; j < m; j++) {
                current = current * powers[j] % modulo;
                result[i, j] = (int)current;
            }
        }

        for (int i = 0; i < answers.Length; i++)
            answers[i] = result[queries[i][0], queries[i][1]];

        return answers;
    }
}
