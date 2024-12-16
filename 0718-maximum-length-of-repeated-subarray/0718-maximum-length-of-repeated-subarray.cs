public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {
        return DP(nums1, nums2);
    }

    private int DP(int[] nums1, int[] nums2) {
        if (nums1.Length == 0 || nums2.Length == 0) return 0;
        if (nums1.Length > nums2.Length) (nums1, nums2) = (nums2, nums1);

        int[] previous = new int[nums1.Length];
        int[] current = new int[nums1.Length];
        int result = 0;

        for (int i = 0; i < nums2.Length; i++) {
            for (int j = 0; j < nums1.Length; j++) {
                current[j] = nums1[j] == nums2[i] ? (j == 0 ? 0 : previous[j - 1]) + 1 : 0;
                result = Math.Max(result, current[j]);
            }

            (previous, current) = (current, previous);
        }

        return result;
    }

    private int DPReverse(int[] nums1, int[] nums2) {
        int[,] dp = new int[nums1.Length + 1, nums2.Length + 1];
        int result = 0;

        for (int i = nums1.Length - 1; i >= 0; i--) {
            for (int j = nums2.Length - 1; j >= 0; j--) {
                dp[i, j] = nums1[i] == nums2[j] ? dp[i + 1, j + 1] + 1 : 0;
                result = Math.Max(result, dp[i, j]);
            }
        }

        return result;
    }
}