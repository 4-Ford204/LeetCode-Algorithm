public class Solution {
    public int MaxProduct(int[] nums) {
        int first = int.MinValue, second = int.MinValue;

        foreach (var num in nums) {
            if (num > second) (first, second) = (second, num);
            else if (num > first) first = num;
        }

        return (first - 1) * (second - 1);
    }
}