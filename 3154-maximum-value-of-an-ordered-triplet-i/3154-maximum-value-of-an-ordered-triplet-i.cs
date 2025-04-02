public class Solution {
    public long MaximumTripletValue(int[] nums) {
        int n = nums.Length, max = 0, maxDouble = 0;
        long maxTriple = 0;

        foreach (var num in nums) {
            maxTriple = Math.Max(maxTriple, (long)maxDouble * num);
            maxDouble = Math.Max(maxDouble, max - num);
            max = Math.Max(max, num);
        }

        return maxTriple;
    }
}