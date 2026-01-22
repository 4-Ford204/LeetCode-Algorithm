public class Solution {
    public int MinimumPairRemoval(int[] nums) {
        var n = new List<int>(nums);
        int result = 0;

        while (true) {
            int index = -1;
            int min = int.MaxValue;
            var sorted = true;

            for (int i = 0; i < n.Count - 1; i++) {
                int current = n[i] + n[i + 1];

                if (n[i] > n[i + 1]) sorted = false;
                if (current < min) {
                    min = current;
                    index = i;
                }
            }

            if (sorted) break;

            n[index] = min;
            n.RemoveAt(index + 1);
            result++;
        }

        return result;
    }
}