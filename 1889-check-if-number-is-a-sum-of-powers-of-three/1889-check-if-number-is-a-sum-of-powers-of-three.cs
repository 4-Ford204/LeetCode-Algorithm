public class Solution {
    public bool CheckPowersOfThree(int n) {
        while (n > 0) {
            if (n % 3 == 0) n /= 3;
            if (n % 3 == 1) n -= 1;
            if (n % 3 == 2) return false;
        }

        return true;
    }
}