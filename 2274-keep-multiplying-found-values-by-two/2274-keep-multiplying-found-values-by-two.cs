public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        while (true) {
            if (!nums.Contains(original)) break;
            original *= 2;
        }

        return original;
    }
}