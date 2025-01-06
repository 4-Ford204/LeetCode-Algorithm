public class Solution {
    public int[] MinOperations(string boxes) {
        int n = boxes.Length, prefixBalls = 0, suffixBalls = 0;
        int[] prefix = new int[n], suffix = new int[n], answer = new int[n];

        for (int i = 0, j = n - 1; i < n && j >= 0; i++, j--) {
            prefix[i] = prefixBalls + prefix[Math.Max(0, i - 1)];
            suffix[j] = suffixBalls + suffix[Math.Min(n - 1, j + 1)];
            prefixBalls += (boxes[i] == '1' ? 1 : 0);
            suffixBalls += (boxes[j] == '1' ? 1 : 0);

            if (i >= j) {
                answer[i] = prefix[i] + suffix[i];
                answer[j] = prefix[j] + suffix[j];
            }
        }

        return answer;
    }
}