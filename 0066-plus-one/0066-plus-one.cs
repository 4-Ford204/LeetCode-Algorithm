public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length, remainder = 1;
        var result = new int[n + 1];
        result[0] = 1;

        for (int i = n - 1; i >= 0; i--) {
            int value = digits[i] + remainder;
            result[i + 1] = value % 10;
            remainder = value / 10;
        }

        return remainder == 0 ? result[1..] : result;
    }
}