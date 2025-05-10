public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        int z1 = 0, z2 = 0;
        long s1 = 0, s2 = 0;

        foreach (var num in nums1) {
            s1 += num;

            if (num == 0) {
                z1++;
                s1++;
            }
        }

        foreach (var num in nums2) {
            s2 += num;
            
            if (num == 0) {
                z2++;
                s2++;
            }
        }

        return (z1 == 0 && s2 > s1) || (z2 == 0 && s1 > s2) ? - 1 : Math.Max(s1, s2);
    }
}