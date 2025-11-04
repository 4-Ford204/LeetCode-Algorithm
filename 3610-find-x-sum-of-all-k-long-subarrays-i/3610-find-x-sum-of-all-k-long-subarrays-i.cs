public class Solution {
    public int[] FindXSum(int[] nums, int k, int x) {
        return Enumerable
            .Range(0, nums.Length - k + 1)
            .Select(index => nums
                .Skip(index)
                .Take(k)
                .GroupBy(group => group)
                .OrderByDescending(group => group.Count())
                .ThenByDescending(group => group.Key)
                .Take(x)
                .Sum(group => group.Key * group.Count())
            )
            .ToArray();
    }
}