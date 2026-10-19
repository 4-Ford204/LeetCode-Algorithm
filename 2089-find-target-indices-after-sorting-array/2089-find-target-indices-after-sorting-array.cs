public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        int start = 0, end = 0;
        var result = new List<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < target) start++;
            else if (nums[i] == target) end++;
        }

        for (int i = start; i < start + end; i++)
            result.Add(i);

        return result;
    }
}