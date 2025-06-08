public class Solution {
    public IList<int> LexicalOrder(int n) {
        int current = 1;
        List<int> result = new List<int>();

        for (int i = 0; i < n; i++) {
            result.Add(current);

            if (current * 10 <= n) current *= 10;
            else {
                while (current % 10 == 9 || current + 1 > n) current /= 10;
                current++;
            }
        }

        return result;
    }

    private IList<int> GenerateLexicographicalNumbers(int n) {
        List<int> result = new List<int>();

        for (int i = 1; i < 10; i++) Recursion(result, i, n);

        return result;
    }

    private void Recursion(List<int> result, int number, int limit) {
        if (number > limit) return;

        result.Add(number);

        for (int i = 0; i < 10; i++) Recursion(result, number * 10 + i, limit);
    }
}