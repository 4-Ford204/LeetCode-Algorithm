public class Solution {
    public int MinimumIndex(IList<int> nums) {
        var frequency = new Dictionary<int, int>();
        int n = nums.Count, max = 0, dominant = 0, count = 0;

        foreach (var num in nums) {
            if (!frequency.TryGetValue(num, out var value)) frequency[num] = 1;
            else frequency[num] = ++value;

            if (value > max) {
                max = value;
                dominant = num;
            }
        }

        for (int i = 0; i < n; i++) {
            if (nums[i] == dominant) count++;
            if ((count * 2 > i + 1) && ((max - count) * 2 > n - i - 1)) return i;
        }

        return -1;
    }
}