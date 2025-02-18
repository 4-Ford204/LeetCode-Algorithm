public class Solution {
    public string SmallestNumber(string pattern) {
        int n = pattern.Length, previous = 0;
        char[] sequence = new char[n + 1];

        for (int i = 0; i <= n; i++) {
            sequence[i] = (char)(i + '1');

            if (i == n || pattern[i] == 'I') {
                Array.Reverse(sequence, previous, i - previous + 1);
                previous = i + 1;
            }
        }

        return new string(sequence);
    }
}