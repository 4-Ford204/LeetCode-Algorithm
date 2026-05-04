public class Solution {
    public int RotatedDigits(int n) {
        int result = 0;

        for (int i = 1; i <= n; i++) {
            if (IsGoodNumber(i)) result++;
        }

        return result;
    }

    private bool IsGoodNumber(int num) {
        bool change = false;

        while (num > 0) {
            var digit = num % 10;
            num /= 10;
            
            if (digit == 3 || digit == 4 || digit == 7) return false;
            if (digit == 2 || digit == 5 || digit == 6 || digit == 9) change = true;
        }

        return change;
    }
}