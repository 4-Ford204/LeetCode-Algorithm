public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        int n = happiness.Length, decrease = 0;
        long result = 0;

        Array.Sort(happiness);

        for (int i = n - 1; i >= 0; i--) {
            int value = happiness[i] - decrease;

            if (k-- <= 0 || value <= 0) break;

            result += value;
            decrease++;
        }

        return result;
    }
}