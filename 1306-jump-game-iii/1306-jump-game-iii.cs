public class Solution {
    public bool CanReach(int[] arr, int start) {
        int n = arr.Length;
        bool[] visited = new bool[n];
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);

        while (queue.Count > 0) {
            int i = queue.Dequeue();

            if (i < 0 || i >= n || visited[i]) continue;
            if (arr[i] == 0) return true;

            visited[i] = true;

            queue.Enqueue(i + arr[i]);
            queue.Enqueue(i - arr[i]);
        }

        return false;
    }
}