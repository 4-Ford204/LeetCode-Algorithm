public class Solution {
    public IList<int> BusiestServers(int k, int[] arrival, int[] load) {
        var free = new PriorityQueue<int, int>();
        var busy = new PriorityQueue<(int, int), int>();
        var count = new int[k];

        for (int i = 0; i < k; i++) free.Enqueue(i, i);
        
        for (int i = 0; i < arrival.Length; i++) {
            int start = arrival[i];

            while (busy.Count > 0 && busy.Peek().Item2 <= start) {
                var server = busy.Dequeue();
                int freeId = ((server.Item1 - i) % k + k) % k + i;
                free.Enqueue(freeId, freeId); 
            }

            if (free.Count > 0) {
                int busyId = free.Dequeue() % k;
                int end = start + load[i];
                busy.Enqueue((busyId, end), end);
                count[busyId]++;
            }
        }

        int max = int.MinValue;
        var result = new List<int>();

        for (int i = 0; i < count.Length; i++) {
            int current = count[i];

            if (current == max) result.Add(i);
            if (current > max) {
                max = current;
                result = new List<int>() { i };
            }
        }

        return result;
    }
}