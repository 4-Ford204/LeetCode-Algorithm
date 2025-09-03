public class Solution {
    public bool IsValidSudoku(char[][] board) {
        /* we use the 'state' variable as flags, where bits 0 to 8 indicate whether a number exists in the row, 
         * bits 9 to 17 in the column, bits 18 to 26 in the box. If a number from 1 to 9 is in the row/column/box,
         * then set the corresponding bit.
         */
        int state = 0;

        bool IsNotValid(int bit)
        {
            if ((state >> bit & 1) > 0)     // check the bit
                return true;                // if the bit is set, it means the number is already in a row/column/box 
    
            state |= 1 << bit;              // set the bit if it is not in a row/column/box
            return false;
        }
            
        for(int i = 0; i < 9; i++)          // loop to iterate rows/columns/boxes
        {
            for(int j = 0; j < 9; j++)      // loop to iterate each cell in row/column/box            
            {
                // 1. Checking each cell in each of the nine rows
                if(board[i][j] != '.')      // '.' is empty cell    
                    if(IsNotValid(board[i][j] - '1'))      // -'1' is converting chars '1'..'9' to bit numbers 0-8
                        return false;

                // 2. Checking each cell in each of the nine columns
                if(board[j][i] != '.') 
                    if(IsNotValid(board[j][i] - '1' + 9))  // +9, because bits 9 to 17 of the state for the column
                        return false;

                // 3. Checking each cell in each of the nine 3x3 sub-boxes of the grid
                int y = j/3 + (i/3)*3;      // calculate the row index for the box
                int x = j%3 + (i%3)*3;      // calculate the column index for the box
                if(board[y][x] != '.')
                    if(IsNotValid(board[y][x] - '1' + 18)) // +18, because bits 18 to 26 of the state for the box
                        return false;
            }
            
            state = 0;                      // clear bits
        }

        return true;
    }
}