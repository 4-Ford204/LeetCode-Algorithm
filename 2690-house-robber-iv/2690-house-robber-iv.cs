public class Solution {
    public int MinCapability(int[] nums, int k) {
        int left = int.MaxValue, right = int.MinValue, result = 0;

        foreach (var num in nums) {
            left = Math.Min(left, num);
            right = Math.Max(right, num);
        }

        while (left <= right) {
            int middle = left + (right - left) / 2;
            int consecutive = 0;

            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] <= middle) {
                    if (++consecutive >= k) {
                        result = middle;
                        break;
                    }

                    i++;
                }
            }

            if (consecutive >= k) right = middle - 1; 
            else left = middle + 1;
        }

        return result;
    }
}