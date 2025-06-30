public class Solution {
    public int FindLHS(int[] nums) {
        var freq = new Dictionary<int, int>();
        var result = 0;

        foreach (var item in nums) {
            freq.TryGetValue(item, out int count);
            freq[item] = count + 1;
        }

        foreach (var item in freq) {
            if (freq.TryGetValue(item.Key + 1, out int value))
                result = Math.Max(result, item.Value + value);
        }

        return result;
    }
}