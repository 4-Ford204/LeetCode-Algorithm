public class Solution {
    public int CountValidSelections(int[] nums) {
        int left = 0, right = 0, result = 0;

        foreach (var num in nums) right += num;

        foreach (var num in nums) {
            if (num == 0) {
                result += left == right ? 2 :
                    Math.Abs(left - right) == 1 ? 1 : 0;
            } else {
                left += num;
                right -= num;
            }
        }

        return result;
    }
}