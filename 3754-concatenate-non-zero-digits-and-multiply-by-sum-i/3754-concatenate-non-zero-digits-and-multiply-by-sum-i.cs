public class Solution {
    public long SumAndMultiply(int n) {
        int count = 1;
        long x = 0, sum = 0;

        while (n > 0) {
            int number = n % 10;
            n /= 10;

            if (number != 0) {
                x = number * count + x;
                sum += number;
                count *= 10;
            }
        }

        return x * sum;
    }
}