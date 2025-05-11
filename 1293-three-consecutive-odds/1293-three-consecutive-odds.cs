public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        for (int i = 2; i < arr.Length; i++) {
            if ((arr[i - 2] & arr[i - 1] & arr[i] & 1) == 1)
                return true;
        }

        return false;
    }
}