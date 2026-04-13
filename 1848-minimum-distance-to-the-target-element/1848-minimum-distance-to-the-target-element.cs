public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int result = int.MaxValue;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == target) result = Math.Min(result, Math.Abs(i - start));
        }

        return result;
    }
}