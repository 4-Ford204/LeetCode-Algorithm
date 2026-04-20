public class Solution {
    public int MaxDistance(int[] nums1, int[] nums2) {
        int result = 0;

        for (int i = 0, j = 0; i < nums1.Length; i++) {
            while (j < nums2.Length && nums1[i] <= nums2[j]) {
                result = Math.Max(result, j - i);
                j++;
            }
        }

        return result;
    }
}