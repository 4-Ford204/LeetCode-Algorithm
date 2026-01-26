public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        int min = int.MaxValue;
        var result = new List<IList<int>>();
        Array.Sort(arr);

        for (int i = 1; i < arr.Length; i++) {
            var currentMin = arr[i] - arr[i - 1];

            if (min < currentMin) continue;
            if (min > currentMin) {
                min = currentMin;
                result.Clear();
            }

            result.Add(new List<int>() { arr[i - 1], arr[i] });
        }

        return result;
    }
}