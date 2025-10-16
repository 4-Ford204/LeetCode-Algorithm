public class Solution {
    public int FindSmallestInteger(int[] nums, int value) {
        int[] remainders = new int[value];
        int result = 0;

        foreach (var num in nums)
            remainders[((num % value) + value) % value]++;

        while (remainders[result % value]-- > 0)
            result++;

        return result;
    }
}