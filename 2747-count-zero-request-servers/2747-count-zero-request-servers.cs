public class Solution {
    public int[] CountServers(int n, int[][] logs, int x, int[] queries) {
        int m = queries.Length, start = 0, end = 0, active = 0;
        int[] ids = Enumerable.Range(0, m).ToArray();
        int[] count = new int[n + 1];
        int[] arr = new int[m];

        Array.Sort(logs, (a, b) => a[1].CompareTo(b[1]));
        Array.Sort(ids, (a, b) => queries[a].CompareTo(queries[b]));

        foreach (int i in ids) {
            int q = queries[i];

            while (end < logs.Length && logs[end][1] <= q) {
                if (count[logs[end++][0]]++ == 0) active++;
            }

            while (start < end && logs[start][1] < q - x) {
                if (--count[logs[start++][0]] == 0) active--;
            }

            arr[i] = n - active;
        }

        return arr;
    }
}