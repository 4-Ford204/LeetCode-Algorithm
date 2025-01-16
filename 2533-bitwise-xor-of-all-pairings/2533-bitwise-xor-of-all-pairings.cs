public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        return 
            nums1.Length % 2 == 0 &&  nums2.Length % 2 == 0 ? 0 :
            nums1.Length % 2 == 0 ? nums1.Aggregate((x, y) => x ^ y) :
            nums2.Length % 2 == 0 ? nums2.Aggregate((x, y) => x ^ y) :
            nums1.Aggregate((x, y) => x ^ y) ^ nums2.Aggregate((x, y) => x ^ y);
    }
}