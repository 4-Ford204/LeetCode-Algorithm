public class Solution {
    public bool CanAliceWin(int n) {
        int remove = 10;

        while (n > 0) {
            if (n < remove) break;
            n -= remove--;
        }

        return remove % 2 != 0;
    }
}