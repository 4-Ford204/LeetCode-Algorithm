public class Solution {
    public int[] MaxDepthAfterSplit(string seq) {
        int n = seq.Length, count = 0;
        var result = new int[n];

        for (int i = 0; i < n; i++) {
            if (seq[i] == '(') {
                count++;
                result[i] = count % 2;
            }

            if (seq[i] == ')') {
                result[i] = count % 2;
                count--;
            }
        }

        return result;
    }
}