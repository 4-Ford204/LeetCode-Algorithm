public class Solution {
    public int MinOperations(int[] nums, int k) {
        HashSet<int> hashset = new HashSet<int>();

        foreach (var num in nums) {
            if (num < k) return -1;
            if (num > k) hashset.Add(num);
        }

        return hashset.Count;
    }
}