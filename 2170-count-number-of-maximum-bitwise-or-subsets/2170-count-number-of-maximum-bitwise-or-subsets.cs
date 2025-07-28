public class Solution {
    public int CountMaxOrSubsets(int[] nums) {
        int maxOR = 0;

        foreach (var num in nums) maxOR |= num;

        int CountSubsets(int index, int currentOR) {
            if (index == nums.Length)
                return currentOR == maxOR ? 1 : 0;

            var includeSubsets = CountSubsets(index + 1, currentOR | nums[index]);
            var excludeSubsets = CountSubsets(index + 1, currentOR);

            return includeSubsets + excludeSubsets;
        }

        return CountSubsets(0, 0);
    }
}