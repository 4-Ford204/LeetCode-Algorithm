public class Solution {
    public int MinNumberOperations(int[] target) {
        int result = target[0];

        for (int i = 1; i < target.Length; i++)
            result += Math.Max(target[i] - target[i - 1], 0);

        return result;
    }
}