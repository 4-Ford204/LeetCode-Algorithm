public class Solution {
    public bool IsUgly(int n) {
        if (n < 1) return false;

        int[] primes = new int[] { 2, 3, 5 };

        foreach (var prime in primes) {
            while (n % prime == 0) n /= prime;
        }

        return n == 1;
    }
}