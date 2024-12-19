public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int n = arr.Length, max = 0, result = 0;

        for (int i = 0; i < n; i++) {
            max = Math.Max(max, arr[i]);
            if (max == i) result++;
        }

        return result++;
    }
}