public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int n = nums.Length, prefix = 0, suffix = 0;
        var answer = new int[n];

        for (int i = 0; i < n; i++) {
            answer[i] = prefix;
            prefix += nums[i];
        }

        for (int i = n - 1; i >= 0; i--) {
            answer[i] = Math.Abs(answer[i] - suffix);
            suffix += nums[i];
        }

        return answer;
    }
}