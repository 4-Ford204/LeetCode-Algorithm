public class Solution {
    public IList<int> FindMissingElements(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length, count = 0;
        var result = new int[nums[n - 1] - nums[0] + 1 - n];

        if (result.Length == 0) return result;

        for (int i = 0; i < n - 1; i++) {
            int current = nums[i], next = nums[i + 1];

            if (current + 1 == next) continue;

            while (current + 1 != next) result[count++] = ++current;
        }

        return result;
    }
}