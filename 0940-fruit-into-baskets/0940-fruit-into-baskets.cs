public class Solution {
    public int TotalFruit(int[] fruits) {
        int current = 0, preConsecutive = 0, result = 0;
        int[] baskets = new int[2];
        baskets[0] = baskets[1] = -1;

        for (int right = 0; right < fruits.Length; right++) {
            if (fruits[right] == baskets[0] || fruits[right] == baskets[1]) current++;
            else current = preConsecutive + 1;

            if (fruits[right] == baskets[1]) preConsecutive++;
            else {
                preConsecutive = 1;
                baskets[0] = baskets[1];
                baskets[1] = fruits[right];
            }

            result = Math.Max(result, current);
        }

        return result;
    }
}