public class Solution {
    private const long modulo = 1_000_000_007;
    private int[] frequency;
    private int[] psum;
    private int target;
    private long[,] combination;
    private long[,,] memoization;

    public int CountBalancedPermutations(string num) {
        int n = num.Length, total = 0;
        frequency = new int[10];
        psum = new int[11];

        foreach (var character in num) {
            int number = character - '0';
            frequency[number]++;
            total += number;
        }

        if (total % 2 != 0) return 0;

        for (int i = 9; i >= 0; i--) psum[i] = psum[i + 1] + frequency[i];

        target = total / 2;
        int maxOdd = (n + 1) / 2;
        combination = new long[maxOdd + 1, maxOdd + 1];
        memoization = new long[10, target + 1, maxOdd + 1];

        for (int i = 0; i <= maxOdd; i++) {
            combination[i, i] = combination[i, 0] = 1;
            for (int j = 1; j < i; j++) combination[i, j] = (combination[i - 1, j] + combination[i - 1, j - 1]) % modulo;
        }

        for (int i = 0; i < 10; i++) {
            for (int j = 0; j <= target; j++) {
                for (int k = 0; k <= maxOdd; k++) memoization[i, j, k] = -1;
            }
        }

        return (int)DFS(0, 0, maxOdd);
    }

    private long DFS(int position, int current, int odd) {
        if (odd < 0 || psum[position] < odd || current > target) return 0;
        if (position > 9) return (current == target && odd == 0) ? 1 : 0;
        if (memoization[position, current, odd] != -1) return memoization[position, current, odd];

        int even = psum[position] - odd;
        long result = 0;

        for (int i = Math.Max(0, frequency[position] - even); i <= Math.Min(frequency[position], odd); i++) {
            long ways = combination[odd, i] * combination[even, frequency[position] - i] % modulo;
            result = (result + ways * DFS(position + 1, current + i * position, odd - i) % modulo) % modulo;
        }

        memoization[position, current, odd] = result;
        return result;
    }
}