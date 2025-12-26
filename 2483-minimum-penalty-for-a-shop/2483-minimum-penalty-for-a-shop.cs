public class Solution {
    public int BestClosingTime(string customers) {
        int result = 0, prefix = 0, minPenalty = 0;

        for (int i = 0; i < customers.Length; i++) {
            prefix += customers[i] == 'Y' ? -1 : 1;

            if (prefix < minPenalty) {
                result = i + 1;
                minPenalty = prefix;
            }
        }

        return result;
    }
}