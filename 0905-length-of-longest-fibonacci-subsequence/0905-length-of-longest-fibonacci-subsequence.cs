public class Solution {
    public int LenLongestFibSubseq(int[] arr) {
        int n = arr.Length, result = 0;
        var index = new Dictionary<int, int>();
        var dp = new Dictionary<(int, int), int>();

        for (int current = 0; current < arr.Length; current++) {
            index[arr[current]] = current;

            for (int previous = 0; previous < current; previous++) {
                int number = arr[current] - arr[previous];

                if (number < arr[previous] && index.TryGetValue(number, out var i)) {
                    int length = dp.GetValueOrDefault((i, previous), 2) + 1; 
                    dp[(previous, current)] = length;
                    result = Math.Max(result, length);
                }
            }
        }

        return result > 2 ? result : 0;
    }
}