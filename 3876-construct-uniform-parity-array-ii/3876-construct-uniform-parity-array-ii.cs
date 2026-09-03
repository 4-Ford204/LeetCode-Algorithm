public class Solution {
    public bool UniformArray(int[] nums1) {
        int n = nums1.Length;
        int odd = 0, min = int.MaxValue;

        foreach (int num in nums1) {
            odd += num % 2 == 1 ? 1 : 0;
            min = Math.Min(min, num);
        }

        return odd == 0 || odd == n || min % 2 == 1;
    }
}