public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        int n = arr.Length, result = 0;

        for (int i = 0; i < n - 2; i++) {
            for (int j = i + 1; j < n - 1; j++) {
                if (Math.Abs(arr[i] - arr[j]) > a) continue;

                for (int k = j + 1; k < n; k++) {
                    if(Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                        result++;
                }
            }
        }

        return result;
    }
}