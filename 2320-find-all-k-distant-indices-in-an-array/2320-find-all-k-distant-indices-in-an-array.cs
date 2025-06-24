public class Solution {
    public IList<int> FindKDistantIndices(int[] nums, int key, int k) {
        int n =nums.Length;
        List<int> result = new List<int>();

        for (int i = 0, right = 0; i < n; i++) {
            if (nums[i] == key) {
                int left = Math.Max(right, i - k);
                right = Math.Min(n - 1, i + k) + 1;

                for (int j = left; j < right; j++)
                    result.Add(j);
            }
        }

        return result;
    }
}