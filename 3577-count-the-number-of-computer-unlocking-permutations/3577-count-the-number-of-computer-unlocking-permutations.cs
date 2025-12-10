public class Solution {
    public int CountPermutations(int[] complexity) {
        int n = complexity.Length, modulo = 1_000_000_007;
        long result = 1;

        for (int i = 1; i < n; i++) {
            if (complexity[i] <= complexity[0]) return 0;
        }
        
        for (int i = 2; i < n; i++) result = result * i % modulo;
        
        return (int)result;
    }
}
