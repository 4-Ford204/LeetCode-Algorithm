public class Solution {
    public int MinimumSumSubarray(IList<int> nums, int l, int r) {
        Span<int> prefix = stackalloc int[nums.Count + 1];
        var result = int.MaxValue;

        for (int i = 0; i < nums.Count; i++) prefix[i + 1] = prefix[i] + nums[i];
        
        for (int i = l; i <= r; i++) {
            for (int j = i; j <= nums.Count; j++) {
                var sum = prefix[j] - prefix[j - i];
                if (sum > 0) result = Math.Min(result, sum); 
            }
        }

        return result == int.MaxValue ? -1 : result;
    }
}