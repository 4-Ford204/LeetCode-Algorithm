public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        var n = spells.Length;
        var m = potions.Length;
        var pairs = new int[n];

        for (int i = 0; i < n; i++) {
            if ((long)spells[i] * potions[m - 1] < success)
                pairs[i] = 0;
            else {
                var left = 0;
                var right = m - 1;

                while (left <= right) {
                    var middle = left + (right - left) / 2;
                    var product = (long)spells[i] * potions[middle];

                    if (product < success) {
                        left = middle + 1;
                    } else if (product >= success) {
                        right = middle - 1;
                    }
                }

                pairs[i] = m - right - 1;
            }
        }

        return pairs;
    }
}