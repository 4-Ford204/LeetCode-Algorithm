public class Solution {
    public int NumberOfAlternatingGroups(int[] colors, int k) {
        int n = colors.Length, previous = colors[0], count = 1, result = 0;

        for (int i = 1; i < n + k - 1; i++) {
            int current = colors[i % n];

            if (current != previous) count++;
            else count = 1;
            
            result += count >= k ? 1 : 0;
            previous = current;
        }

        return result;
    }
}