public class Solution {
    public int MinimumOperations(int[] nums) {
        bool[] seen = new bool[101];

        for (int i = nums.Length - 1; i >= 0; i--) {
            if (seen[nums[i]]) return i / 3 + 1;
            seen[nums[i]] = true;
        }

        return 0;
    }
}