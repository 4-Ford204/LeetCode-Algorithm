public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        for (int i = 0, j = 0; i < nums1.Length && j < nums2.Length;) {
            if (nums1[i] > nums2[j]) j++;
            else if (nums1[i] < nums2[j]) i++;
            else return nums1[i];
        }

        return -1;
    }
}