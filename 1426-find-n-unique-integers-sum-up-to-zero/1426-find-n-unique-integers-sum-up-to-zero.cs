public class Solution {
    public int[] SumZero(int n) {
        int[] result = new int[n];
        int count = 0;

        for (int i = 1; i <= n / 2; i++) {
            result[count++] = i;
            result[count++] = -i;
        }

        if (n % 2 == 1) result[n - 1] = 0;

        return result;
    }
}