public class Solution {
    public int MinOperations(int[] nums, int x) {
        int n = nums.Length, target = -x;
        int sum = 0, maxLength = 0;

        foreach (int num in nums) target += num;

        if (target == 0) return n;

        for (int start = 0, end = 0; end < n; end++) {
            sum += nums[end];

            while (start <= end && sum > target)
                sum -= nums[start++];

            if (sum == target)
                maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength == 0 ? -1 : n - maxLength;
    }
}