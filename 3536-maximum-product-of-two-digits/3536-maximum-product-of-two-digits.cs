public class Solution {
    public int MaxProduct(int n) {
        int first = int.MinValue, second = int.MinValue;

        while (n > 0) {
            int num = n % 10;
            n /= 10;

            if (num > second) {
                first = second;
                second = num;
            }
            else if (num > first) first = num;
        }

        return first * second;
    }
}