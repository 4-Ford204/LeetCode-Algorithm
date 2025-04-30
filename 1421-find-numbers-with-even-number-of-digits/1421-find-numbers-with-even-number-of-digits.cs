public class Solution {
    public int FindNumbers(int[] nums) {
        int result = 0;

        foreach (var num in nums) {
            if (num.ToString().Length % 2 == 0) result++;
        }

        return result;
    }

    private int Linq(int[] nums) {
        return nums.Where(num => num.ToString().Length % 2 == 0).Count();
    }
}