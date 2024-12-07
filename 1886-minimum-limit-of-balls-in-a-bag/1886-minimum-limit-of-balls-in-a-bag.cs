public class Solution {
    public int MinimumSize(int[] nums, int maxOperations) {
        int left = 1;
        int right = (int)Math.Pow(10, 9);

        while (left <= right) {
            int middle = left + (right - left) / 2;
            int operation = 0;

            foreach (var num in nums) {
                if (num > middle) 
                    operation += (int)Math.Ceiling(num / (double)middle) - 1;
            }

            if (operation <= maxOperations) right = middle - 1;
            else left = middle + 1;
        }

        return left;
    }
}