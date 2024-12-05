public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        PriorityQueue<int, int> heapFirst = new PriorityQueue<int, int>();
        PriorityQueue<int, int> heapLast = new PriorityQueue<int, int>();
        long total = 0;
        int first = 0;
        int last = costs.Length - 1;

        for (int i = 0; i < k; i++) {
            while (heapFirst.Count < candidates && first <= last) {
                heapFirst.Enqueue(costs[first], costs[first]);
                first++;
            }

            while (heapLast.Count < candidates && last >= first) {
                heapLast.Enqueue(costs[last], costs[last]);
                last--;
            }

            if (heapFirst.Count == 0) {
                total += heapLast.Dequeue();
            } else if (heapLast.Count == 0) {
                total += heapFirst.Dequeue();
            } else if (heapFirst.Peek() <= heapLast.Peek()) {
                total += heapFirst.Dequeue();
            } else {
                total += heapLast.Dequeue();
            }
        }

        return total;
    }
}