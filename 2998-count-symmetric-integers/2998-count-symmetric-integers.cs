public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        int result = 0;

        for (int i = low; i <= high; i++) {
            int n = i.ToString().Length, number = i, j = 1;
            int[] dp = new int[n + 1];

            if (n % 2 == 0) {
                while (number > 0 && j < n + 1) {
                    dp[j] = dp[j - 1] + number % 10;
                    number /= 10;
                    j++;
                }

                if (dp[n / 2] * 2 == dp[n]) result++;
            }
        }

        return result;
    }
}