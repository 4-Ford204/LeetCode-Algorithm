public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        Array.Sort(capacity);
        int space = 0, result = 0;

        foreach (var x in apple) space += x;

        for (int i = capacity.Length - 1; i >= 0; i--) {
            space -= capacity[i];
            result++;

            if (space <= 0) break;
        }

        return result;
    }
}