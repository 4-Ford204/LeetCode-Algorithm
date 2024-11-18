public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int n = code.Length;
        int[] result = new int[n];
        int sum = 0;

        if (k > 0) {
            for (int i = 1; i <= k; i++) sum += code[i];
            result[0] = sum;

            for (int i = 1; i < n; i++) {
                sum += code[(i + k) % n] - code[i];
                result[i] = sum;
            }
        }

        if (k < 0) {
            for (int i = -1; i >= k; i--) sum += code[n + i];
            result[0] = sum;

            for (int i = 0; i < n - 1; i++) {
                sum += code[i] - code[(n + i + k) % n];
                result[i + 1] = sum;
            }
        } 
        
        return result;
    }
}