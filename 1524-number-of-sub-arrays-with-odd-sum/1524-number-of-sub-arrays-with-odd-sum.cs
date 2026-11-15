public class Solution {
    public int NumOfSubarrays(int[] arr) {
        var odd = 0;
        var sum = 0;

        foreach (var num in arr) {
            sum += num;
            odd += sum % 2;
        }

        var even = arr.Length - odd;

        return (int)((1L * even * odd + odd) % 1_000_000_007);
    }

    private int DP(int[] arr) {
        int n = arr.Length, modulo = 1_000_000_007, result = 0;
        int[] dpOdd = new int[n], dpEven = new int[n];

        if (arr[0] % 2 == 1) dpOdd[0] = 1;
        else dpEven[0] = 1;

        for (int i = 1; i < n; i++) {
            if (arr[i] % 2 == 1) {
                dpOdd[i] = (1 + dpEven[i - 1]) % modulo;
                dpEven[i] = dpOdd[i - 1];
            } else {
                dpOdd[i] = dpOdd[i - 1];
                dpEven[i] = (1 + dpEven[i - 1]) % modulo;
            }

            result = (result + dpOdd[i]) % modulo;
        }

        return result + dpOdd[0];
    }
}