public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        int n = spells.Length, m = potions.Length;
        var result = new int[n];

        for (int i = 0; i < n; i++) {
            if ((long)spells[i] * potions[m - 1] >= success) { 
                int left = 0, right = m - 1;

                while (left <= right) {
                    var middle = (right - left) / 2 + left;
                    var product = (long)spells[i] * potions[middle];

                    if (product < success) left = middle + 1;
                    else right = middle - 1;
                }

                result[i] = m - left;
            }
        }

        return result;
    }
}