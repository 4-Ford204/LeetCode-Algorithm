public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        int z1 = 0, z2 = 0;
        long s1 = 0, s2 = 0;

        foreach (var num in nums1) {
            if (num == 0) z1++;
            else s1 += num;
        }

        foreach (var num in nums2) {
            if (num == 0) z2++;
            else s2 += num;
        }

        return ((z1 == 0 && z2 + s2 > s1) || (z2 == 0 && z1 + s1 > s2)) ? - 1 : Math.Max(z1 + s1, z2 + s2);
    }
}