public class Solution {
    public double MyPow(double x, int n) {
        double result = 1, current = x, i = n;

        if (n < 0) {
            current = 1 / current;
            i = -i;
        }

        while (i > 0) {
            if (i % 2 == 1) result *= current;
            current *= current;
            i = Math.Floor(i / 2);
        }

        return result;
    }
}