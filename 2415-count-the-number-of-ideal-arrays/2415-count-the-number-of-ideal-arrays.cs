public class Solution {
    const int MODULO = 1_000_000_007;
    const int MAX_N = 10010;
    const int MAX_P = 15;
    int[,] combination = new int[MAX_N + MAX_P, MAX_P + 1];
    int[] sieves = new int[MAX_N];
    List<int>[] primes = new List<int>[MAX_N];

    public Solution() {
        if (combination[0, 0] == 1) return;

        for (int i = 0; i < MAX_N; i++) primes[i] = new List<int>();

        for (int i = 2; i < MAX_N; i++) {
            if (sieves[i] == 0) {
                for (int j = i; j < MAX_N; j += i) {
                    if (sieves[j] == 0) sieves[j] = i;
                }
            }
        }

        for (int i = 2; i < MAX_N; i++) {
            int x = i;

            while (x > 1) {
                int sieve = sieves[x], prime = 0;

                while (x % sieve == 0) {
                    x /= sieve;
                    prime++;
                }

                primes[i].Add(prime);
            }
        }

        combination[0, 0] = 1;

        for (int i = 1; i < MAX_N + MAX_P; i++) {
            combination[i, 0] = 1;

            for (int j = 1; j <= Math.Min(i, MAX_P); j++) {
                combination[i, j] = (combination[i - 1, j] + combination[i - 1, j - 1]) % MODULO;
            }
        }
    }

    public int IdealArrays(int n, int maxValue) {
        long result = 0;

        for (int i = 1; i <= maxValue; i++) {
            long multi = 1;

            foreach (var prime in primes[i])
                multi = multi * combination[n + prime - 1, prime] % MODULO;

            result = (result + multi) % MODULO;
        }

        return (int)result;
    }
}