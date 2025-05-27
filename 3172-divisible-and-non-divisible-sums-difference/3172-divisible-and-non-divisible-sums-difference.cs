public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int num2 = 0, count = 1;
        int total = (n + 1) * n / 2;

        if (m == 1) return -total;

        while (m * count <= n) num2 += m * count++;

        return total - 2 * num2;
    }
}