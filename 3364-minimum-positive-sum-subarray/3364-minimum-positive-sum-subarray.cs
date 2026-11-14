public class Solution {
    public int MinimumSumSubarray(IList<int> nums, int l, int r) {
        int result = int.MaxValue;

        for (int i = l; i <= r; i++) {
            int sum = 0;

            for (int j = 0; j < i; j++) sum += nums[j];

            if (sum > 0) result = Math.Min(result, sum);

            for (int j = i; j < nums.Count; j++) {
                sum += nums[j] - nums[j - i];

                if (sum > 0) result = Math.Min(result, sum);
            }
        }

        return result == int.MaxValue ? -1 : result;
    }
}