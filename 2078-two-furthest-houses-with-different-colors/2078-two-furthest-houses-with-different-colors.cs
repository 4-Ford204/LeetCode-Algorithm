public class Solution {
    public int MaxDistance(int[] colors) {
        int n = colors.Length, result = 0;

        for (int i = 0, j = n - 1; i < j; i++) {
            if (colors[i] != colors[j]) result = Math.Max(result, j - i);
        }

        for (int i = 0, j = n - 1; i < j; j--) {
            if (colors[i] != colors[j]) result = Math.Max(result, j - i);
        }

        return result;
    }
}