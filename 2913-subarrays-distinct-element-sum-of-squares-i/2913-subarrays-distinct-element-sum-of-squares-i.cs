public class Solution {
    public int SumCounts(IList<int> nums) {
        int n = nums.Count, result = 0;

        for (int i = 0; i < n; i++) {
            var hashset = new HashSet<int>();

            for (int j = i; j < n; j++) {
                hashset.Add(nums[j]);
                result += hashset.Count * hashset.Count;
            }
        }

        return result;
    }
}