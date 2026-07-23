public class Solution {
    public int UniqueXorTriplets(int[] nums) {
        int n = nums.Length, result = 1;

        if (n <= 2) return n;

        while (result <= n) result <<= 1;

        return result;
    }
}