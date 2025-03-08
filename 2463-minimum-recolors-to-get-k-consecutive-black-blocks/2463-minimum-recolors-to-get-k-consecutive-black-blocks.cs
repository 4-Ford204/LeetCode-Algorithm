public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int result = 0, current;

        for (int i = 0; i < k; i++) result += blocks[i] == 'W' ? 1 : 0;

        current = result;

        for (int i = k; i < blocks.Length; i++) {
            current += (blocks[i] == 'W' ? 1 : 0) - (blocks[i - k] == 'W' ? 1 : 0);
            result = Math.Min(result, current);
        }

        return result;
    }
}