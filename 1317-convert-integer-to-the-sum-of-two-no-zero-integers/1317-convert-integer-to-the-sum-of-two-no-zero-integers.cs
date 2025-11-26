public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int number = 1;

        while (!IsNoZeroInteger(number) || !IsNoZeroInteger(n - number))
            number++;
        
        return new int[] { number, n - number };
    }

    private bool IsNoZeroInteger(int n) {
        while (n > 0) {
            if (n % 10 == 0) return false;
            n /= 10;
        }

        return true;
    }
}