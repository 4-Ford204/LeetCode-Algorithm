public class Solution {
    public int MaxSubarrayLength(int[] nums, int k) {
        int n = nums.Length, start = 0, result = 0;
        var map = new Dictionary<int, int>();

        for (int end = 0; end < n; end++) {
            int num = nums[end];

            if (map.ContainsKey(num)) map[num]++;
            else map[num] = 1;

            while (map[num] > k) map[nums[start++]]--;

            result = Math.Max(result, end - start + 1);
        }

        return result;
    }
}