public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int n = nums.Length;
        var result = new List<int>();

        for (int i = 0; i < n; i++) {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0) nums[index] = -nums[index];
        }

        for (int i = 0; i < n; i++) {
            if (nums[i] > 0) result.Add(i + 1);
        }

        return result;
    }
}