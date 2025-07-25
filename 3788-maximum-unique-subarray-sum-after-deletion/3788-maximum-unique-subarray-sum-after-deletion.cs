public class Solution {
    public int MaxSum(int[] nums) {
        HashSet<int> hashset = new HashSet<int>();
        int positive = 0, negative = int.MinValue;

        foreach (var num in nums) {
            if (num < 0) negative = Math.Max(negative, num);
            else if (!hashset.Contains(num)) {
                positive += num;
                hashset.Add(num);
            }
        }

        return hashset.Contains(0) || positive > 0 ? positive : negative;
    }
}