public class Solution {
    public long CountGood(int[] nums, int k) {
        int n = nums.Length, pairs = 0, right = -1;
        long result = 0;
        var frequency = new Dictionary<int, int>();

        for (int left = 0; left < n; left++) {
            while (pairs < k && right + 1 < n) {
                int num = nums[++right];
                frequency.TryGetValue(num, out int value);
                pairs += value;
                frequency[num] = value + 1;
            }

            if (pairs >= k) result += n - right;

            pairs -= --frequency[nums[left]];
        }

        return result;
    }
}