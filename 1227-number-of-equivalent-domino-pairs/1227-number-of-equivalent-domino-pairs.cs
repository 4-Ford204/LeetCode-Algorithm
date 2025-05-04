public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        int result = 0;
        int[] value = new int[100];

        foreach (var domino in dominoes) {
            if (domino[0] < domino[1]) (domino[0], domino[1]) = (domino[1], domino[0]);

            int index = domino[0] * 10 + domino[1];
            result += value[index]++;
        }

        return result;
    }
}