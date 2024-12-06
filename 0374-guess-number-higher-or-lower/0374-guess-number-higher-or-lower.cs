/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int left = 1;
        int right = n;

        while (left <= right) {
            int middle = left + (right - left) / 2;
            int response = guess(middle);

            if (response == -1) 
                right = middle - 1;
            else if (response == 1) 
                left = middle + 1;
            else 
                return middle;
        }

        return -1;
    }
}