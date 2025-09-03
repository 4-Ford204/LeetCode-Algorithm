public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int n = board.Length;
        int[] rows = new int[n], columns = new int[n], boxes = new int[n];
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i][j] == '.') continue;

                int value = (board[i][j] - '0') - 1;
                int bit = 1 << value;
                int k = (i / 3) * 3 + j / 3;

                if (
                    (rows[i] & bit) > 0 ||
                    (columns[j] & bit) > 0 ||
                    (boxes[k] & bit) > 0
                )
                    return false;
                else {
                    rows[i] |= bit;
                    columns[j] |= bit;
                    boxes[k] |= bit;
                }
            }
        }

        return true;
    }
}