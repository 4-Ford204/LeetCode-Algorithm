public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        var result = new List<IList<int>>();
        var counter = new Dictionary<int, int>();

        foreach (var num in nums) {
            if (!counter.ContainsKey(num)) counter.Add(num, 0);
            counter[num]++;
        }
        
        GetPermutation(new List<int>(), nums.Length, counter, result);

        return result;
    }

    private void GetPermutation(List<int> current, int n, Dictionary<int, int> counter, List<IList<int>> result) {
        if (current.Count == n) {
            result.Add(new List<int>(current));
            return;
        }

        foreach (var (num, count) in counter.ToList()) {
            if (count == 0) continue;

            counter[num]--;
            current.Add(num);

            GetPermutation(current, n, counter, result);

            current.RemoveAt(current.Count - 1);
            counter[num]++;
        }
    }
}