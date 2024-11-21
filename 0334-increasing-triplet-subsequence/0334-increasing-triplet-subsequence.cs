public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int length = nums.Length;
        int i = int.MaxValue;
        int j = int.MaxValue;

        if (length <= 2) return false;

        foreach (int k in nums) {
            if (k <= i) i = k;
            else if (k <= j) j = k;
            else return true; 
        }

        return false;
    }
}