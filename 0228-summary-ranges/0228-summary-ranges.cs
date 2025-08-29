public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        int index = 0, n = nums.Length;
        var result = new List<string>();

        while (index < n) {
            int start = index;

            while (index + 1 < n && nums[index] + 1 == nums[index + 1]) index++;

            if (start == index) result.Add($"{nums[start]}");
            else result.Add($"{nums[start]}->{nums[index]}");

            index++;
        }

        return result;
    }
}