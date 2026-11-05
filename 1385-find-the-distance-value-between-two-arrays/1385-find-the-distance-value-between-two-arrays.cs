public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        int result = 0, n = arr2.Length;

        Array.Sort(arr2);

        foreach (var num in arr1) {
            int index = Array.BinarySearch(arr2, num);

            if (index < 0) index = ~index;

            int L = index - 1, R = index;
            var current = true;

            if (L >= 0 && L < n) current &= (num - arr2[L] > d);
            if (R < n) current &= (arr2[R] - num > d);
            if (current) result++;
        }

        return result;
    }
}