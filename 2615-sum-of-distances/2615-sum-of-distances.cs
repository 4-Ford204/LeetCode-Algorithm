public class Solution {
    public long[] Distance(int[] nums) {
        var group = new Dictionary<int, List<int>>();
        var arr = new long[nums.Length];

        for (int i = 0; i < nums.Length; i++) {
            if (!group.ContainsKey(nums[i])) group[nums[i]] = new List<int>();
            group[nums[i]].Add(i);
        }

        foreach (var indices in group.Values) {
            int n = indices.Count;
            long sum = 0, prefixSum = 0;

            foreach (var index in indices) sum += index;

            for (int i = 0; i < n; i++) {
                int index = indices[i];
                arr[index] = sum - 2 * prefixSum + (long)index * (2 * i - n);
                prefixSum += index;
            }
        }

        return arr;
    }
}