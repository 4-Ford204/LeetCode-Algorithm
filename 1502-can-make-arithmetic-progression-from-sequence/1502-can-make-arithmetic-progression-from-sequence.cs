public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int n = arr.Length;

        if (n >= 3) {
            for (int i = 2; i < n; i++) {
                if (arr[i] + arr[i - 2] != 2 * arr[i - 1])
                    return false;
            }
        }

        return true;
    }
}