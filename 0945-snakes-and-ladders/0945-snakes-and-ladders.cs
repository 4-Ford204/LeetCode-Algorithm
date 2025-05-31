public class Solution {
    public int SnakesAndLadders(int[][] board) {
        int n = board.Length;
        Queue<(int square, int move)> queue = new Queue<(int, int)>();
        HashSet<int> hashset = new HashSet<int>();

        queue.Enqueue((1, 0));
        Array.Reverse(board);

        while (queue.Count > 0) {
            var (square, move) = queue.Dequeue();

            for (int i = 1; i < 7; i++) {
                int next = square + i;
                int r = (next - 1) / n;
                int c = r % 2 == 0 ? (next - 1) % n : n - 1 - (next - 1) % n;

                if (board[r][c] != - 1) next = board[r][c];

                if (next == n * n) return move + 1;

                if (!hashset.Contains(next)) {
                    hashset.Add(next);
                    queue.Enqueue((next, move + 1));
                }
            }
        }

        return -1;
    }
}