public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        return SieveOfEratosthenes(left, right);
    }

    private int[] BruteForce(int left, int right) {
        int num1 = -1, num2 = -1, count = 0;
        int[] result = new int[2] { -1, -1 };

        while (left <= right && count < 2) {
            if (IsPrime(left++)) result[count++] = left - 1;
        }

        if (count < 2) return new int[] { -1, -1 };
        else (num1, num2) = (result[0], result[1]);

        for (int i = left; i <= right; i++) {
            if (IsPrime(i)) {
                (num1, num2) = (num2, i);
                if (num2 - num1 < result[1] - result[0]) (result[0], result[1]) = (num1, num2);
            }
        }

        return result;
    }

    private bool IsPrime(int number) {
        if (number <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++) {
            if (number % i == 0) return false;
        }

        return true;
    }

    private int[] SieveOfEratosthenes(int left, int right) {
        int[] sieve = new int[right + 1], result = new int[2];
        List<int> primeNumbers = new List<int>();
        int minDifference = int.MaxValue;
        Array.Fill(sieve, 1);
        sieve[0] = 0;
        sieve[1] = 0;
        Array.Fill(result, -1);

        for (int number = 2; number * number <= right; number++) {
            if (sieve[number] == 1) {
                for (int multiple = number * number; multiple <= right; multiple += number)
                    sieve[multiple] = 0;
            }
        }

        for (int number = left; number <= right; number++) {
            if (sieve[number] == 1) primeNumbers.Add(number);
        }

        if (primeNumbers.Count < 2) return new int[] { -1, -1 };

        for (int i = 1; i < primeNumbers.Count; i++) {
            int difference = primeNumbers[i] - primeNumbers[i - 1];

            if (difference < minDifference) {
                minDifference = difference;
                result[0] = primeNumbers[i - 1];
                result[1] = primeNumbers[i];
            }
        }

        return result;
    }
}