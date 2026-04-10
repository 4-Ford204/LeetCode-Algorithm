public class Solution {
    public int MinimumDistance(int[] nums) {
        int n = nums.Length, result = int.MaxValue;
        var map = new Dictionary<int, List<int>>();

        for (int i = 0; i < n; i++) {
            int num = nums[i];
            if (!map.ContainsKey(num)) map[num] = new List<int>();
            map[num].Add(i);
        }

        foreach (var (key, arr) in map) {
            if (arr.Count >= 3) {
                for (int index = 0; index < arr.Count - 2; index++) {
                    int i = arr[index], k = arr[index + 2];
                    result = Math.Min(result, 2 * (k - i));
                }
            }
        }

        return result == int.MaxValue ? -1 : result;
    }
}