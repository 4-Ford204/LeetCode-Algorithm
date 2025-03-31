public class Solution {
    public long PutMarbles(int[] weights, int k) {
        int n = weights.Length;
        int[] pairWeights = new int[n - 1];
        long result = 0;

        for (int i = 0; i < n - 1; i++) pairWeights[i] = weights[i] + weights[i + 1];

        Array.Sort(pairWeights);
        
        for (int i = 0; i < k - 1; i++) result += pairWeights[n - 2 - i] - pairWeights[i];

        return result;
    }
}