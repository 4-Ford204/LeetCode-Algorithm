public class Solution {
    public bool ValidMountainArray(int[] arr) {
        var decreasing = false;

        if (arr.Length < 3 || arr[0] > arr[1]) return false;

        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] == arr[i - 1]) return false;

            if (!decreasing) {
                if (arr[i] < arr[i - 1]) decreasing = true;
            } else {
                if (arr[i] > arr[i - 1]) return false;
            }
        }

        return decreasing;
    }
}