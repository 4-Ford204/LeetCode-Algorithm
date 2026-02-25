public class Solution {
    public int[] SortByBits(int[] arr) {
        int n = arr.Length;
        var bit = new Dictionary<int, int>();

        foreach (var item in arr) {
            if (!bit.ContainsKey(item)) {
                int num = item, count = 0;

                while (num > 0) {
                    num = num & (num - 1);
                    count++;
                }

                bit[item] = count;
            }
        }

        for (int i = 0; i < n; i++) {
            bool swap = false;

            for (int j = 0; j < n - 1; j++) {
                if (
                    bit[arr[j]] > bit[arr[j + 1]] ||
                    (bit[arr[j]] == bit[arr[j + 1]] && arr[j] > arr[j + 1])
                ) {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swap = true;
                }
            }

            if (!swap) break;
        }

        return arr;
    }
}