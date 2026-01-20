public class Solution {
    public int[] MinBitwiseArray(IList<int> nums) {
        var ans = new int[nums.Count];

        for (int i = 0; i < nums.Count; i++) {
            int n = nums[i];
            ans[i] = n != 2 ? n - ((n + 1) & (-n - 1)) / 2 : -1;
        }

        return ans;
    }
}