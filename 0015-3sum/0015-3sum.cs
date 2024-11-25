public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k) {
                int total = nums[i] + nums[j] + nums[k];

                if (total > 0) k--;
                else if (total < 0) j++;
                else {
                    result.Add([nums[i], nums[j], nums[k]]);
                    j++;

                    while (nums[j] == nums[j - 1] && j < k) j++;
                }
             }
        }

        return result;
    }
}