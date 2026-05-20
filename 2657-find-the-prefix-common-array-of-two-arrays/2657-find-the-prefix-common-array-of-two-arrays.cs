public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        int n = A.Length, prefix = 0;
        int[] C = new int[n], arr = new int[n + 1];

        for (int i = 0; i < n; i++) {
            int a = A[i], b = B[i];

            if ((arr[a] ^= a) == 0) prefix++; 
            if ((arr[b] ^= b) == 0) prefix++;

            C[i] = prefix;
        }

        return C;
    }
}