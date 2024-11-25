public class Solution {
    public int SlidingPuzzle(int[][] board) {
        Queue<(string, int)> queue = new Queue<(string, int)>();
        HashSet<string> hashSet = new HashSet<string>();
        int[][] moves = {
            [ 1, 3 ],
            [ 0, 2, 4 ],
            [ 1, 5 ],
            [ 0, 4 ],
            [ 1, 3, 5 ],
            [ 2, 4 ]
        };
        string target = "123450";
        string start = "";

        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 3; j++) start += board[i][j] + "";
        }

        if (start == target) return 0;
        queue.Enqueue((start, 0));
        hashSet.Add(start);
        
        while (queue.Count > 0) {
            var (current, step) = queue.Dequeue();
            int emptyIndex = current.IndexOf('0');

            foreach (var move in moves[emptyIndex]) {
                string next = Move(current, emptyIndex, move);

                if (next == target) 
                    return step + 1;

                if (!hashSet.Contains(next)) {
                    queue.Enqueue((next, step + 1));
                    hashSet.Add(next);
                }
            }
        }

        return -1;
    }

    private string Move(string current, int emptyIndex, int targetIndex) {
        char[] chars = current.ToCharArray();

        chars[emptyIndex] = chars[targetIndex];
        chars[targetIndex] = '0';

        return new String(chars);
    }
}