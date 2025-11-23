public class Solution {
    public int MaxSumDivThree(int[] nums) {
        int[] result = { 0, int.MinValue, int.MinValue };

        foreach (var num in nums) {
            int[] current = new int[3];
            Array.Copy(result, current, 3);

            for (int i = 0; i < 3; i++) {
                var j = (i + num % 3) % 3;
                current[j] = Math.Max(current[j], result[i] + num);
            }

            result = current;
        }

        return result[0];
    }
}