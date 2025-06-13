public class Solution {
    public int MinimizeMax(int[] nums, int p) {
        Array.Sort(nums);
        int n = nums.Length, left = 0, right = nums[n - 1];

        while (left <= right) {
            int middle = left + (right - left) / 2;
            int pairs = 0;

            for (int i = 0; i < n - 1; i++) {
                int diff = nums[i + 1] - nums[i];

                if (diff <= middle) {
                    pairs++;
                    i++;
                }
            }

            if (pairs >= p) right = middle - 1;
            else left = middle + 1;
        }

        return left;
    }
}