public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (map.TryGetValue(complement, out var index))
                return new int[] { index, i };
            map[nums[i]] = i;
        }
        return new int[] {};
    }
}