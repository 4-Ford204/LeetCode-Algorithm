public class Solution {
    public int LargestInteger(int[] nums, int k) {
        int n = nums.Length, max = int.MinValue;
        var map = new int[51];

        foreach (int num in nums) {
            max = Math.Max(max, num);
            map[num]++;
        }
        
        if (k == n) return max;

        if (k == 1) {
            for (int i = 50; i >= 0; i--) {
                if (map[i] == 1) return i;
            }

            return -1;
        }

        return Math.Max(
            map[nums[0]] == 1 ? nums[0] : -1,
            map[nums[n - 1]] == 1 ? nums[n - 1] : -1
        );
    }
}