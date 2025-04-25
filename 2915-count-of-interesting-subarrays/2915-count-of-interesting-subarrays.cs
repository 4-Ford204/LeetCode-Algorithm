public class Solution {
    public long CountInterestingSubarrays(IList<int> nums, int modulo, int k) {
        int prefix = 0;
        var seen = new Dictionary<int, int>() { { 0, 1 } };
        long result = 0;

        foreach (int num in nums)
        {
            prefix += (num % modulo == k) ? 1 : 0;
            int target = (prefix - k) % modulo;
            int key = prefix % modulo;

            if (target < 0) target += modulo;

            if (seen.TryGetValue(target, out int count)) result += count;
            
            if (key < 0) key += modulo;

            if (seen.ContainsKey(key)) seen[key]++;
            else seen[key] = 1;
        }

        return result;
    }
}