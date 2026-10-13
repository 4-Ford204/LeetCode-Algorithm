public class Solution {
    public long MaxAlternatingSum(int[] nums) {
        int n = nums.Length;
        var result = 0L;

        for (int i = 0; i < n; i++) nums[i] = nums[i] * nums[i];

        Array.Sort(nums, (a, b) => a.CompareTo(b));

        for (int i = 0, j = n - 1; i < n / 2; i++, j--)
            result += nums[j] - nums[i];
        
        if (n % 2 == 1) result += nums[n / 2];

        return result;
    }
}