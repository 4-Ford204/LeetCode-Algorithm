public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        int n = fruits.Length, result = 0, j = 0;

        for (int i = 0; i < n; i++) {
            for (j = 0; j < n; j++) {
                if (baskets[j] >= fruits[i]) {
                    baskets[j] = 0;
                    break;
                }
            }

            if (j == n) result++;
        }

        return result;
    }
}