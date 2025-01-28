public class Solution {
    public int[] LexicographicallySmallestArray(int[] nums, int limit) {
        int n = nums.Length, start = 0, end = 0, previous = int.MinValue;
        (int value, int index)[] tuples = new (int, int)[n];
        List<int> positions = new List<int>();
        int[] result = new int[n];

        for (int i = 0; i < n; i++) tuples[i] = (nums[i], i);
        Array.Sort(tuples, (x, y) => x.value.CompareTo(y.value));

        while (end < n) {
            positions.Add(tuples[end].index);
            previous = tuples[end].value;
            end++;

            if (end == n || tuples[end].value - previous > limit) {
                positions.Sort();

                foreach (var position in positions) result[position] = tuples[start++].value;

                positions.Clear();
            }
        }

        return result;
    }
}