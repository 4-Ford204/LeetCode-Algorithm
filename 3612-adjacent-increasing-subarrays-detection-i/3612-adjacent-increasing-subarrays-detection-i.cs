public class Solution {
    public bool HasIncreasingSubarrays(IList<int> nums, int k) {
        int n = nums.Count, count = 0;

        if (k == 1) return true;

        for (int i = 1; i < n - k; i++) {
            count = (nums[i] > nums[i - 1] && nums[i + k] > nums[i - 1 + k]) ? count + 1 : 0;
            if (count == k - 1) return true;
        }

        return false;
    }
}