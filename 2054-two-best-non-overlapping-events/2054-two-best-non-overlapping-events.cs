public class Solution {
    public int MaxTwoEvents(int[][] events) {
        Array.Sort(events, (x, y) => x[1].CompareTo(y[1]));
        int n = events.Length, result = 0;
        int[] prefixMax = new int[n];
        prefixMax[0] = events[0][2];

        for (int i = 1; i < n; i++) 
            prefixMax[i] = Math.Max(prefixMax[i - 1], events[i][2]);

        for (int i = 0; i < n; i++) {
            int startTime = events[i][0];
            int value = events[i][2];
            int left = 0, right = i - 1, maxIndex = -1;

            while (left <= right) {
                int middle = left + (right - left) / 2;

                if (events[middle][1] < startTime) {
                    maxIndex = middle;
                    left = middle + 1;
                } else right = middle - 1;
            }

            int preMaxValue = maxIndex == -1 ? 0 : prefixMax[maxIndex];
            result = Math.Max(result, value + preMaxValue);
        }

        return result;
    }

    private int Greedy(int[][] events) {
        List<int[]> timeline = new List<int[]>();
        int result = 0, preMaxValue = 0;

        foreach (int[] e in events) {
            timeline.Add(new int[] { e[0], 1, e[2] });
            timeline.Add(new int[] { e[1] + 1, 0, e[2] });
        }

        timeline.Sort((x, y) => x[0] == y[0] ? x[1].CompareTo(y[1]) : x[0].CompareTo(y[0]));

        foreach (var time in timeline) {
            if (time[1] == 1) result = Math.Max(result, time[2] + preMaxValue);
            else preMaxValue = Math.Max(preMaxValue, time[2]);
        }

        return result;
    }

    private int MinHeap(int[][] events) {
        var heap = new PriorityQueue<(int endTime, int value), int>();
        Array.Sort(events, (x, y) => x[0].CompareTo(y[0]));
        int preMaxValue = 0, maxTotal = 0;

        foreach (var e in events) {
            while (heap.Count != 0 && heap.Peek().endTime < e[0])
                preMaxValue = Math.Max(preMaxValue, heap.Dequeue().value);
                
            maxTotal = Math.Max(maxTotal, preMaxValue + e[2]);
            heap.Enqueue((e[1], e[2]), e[1]);
        }

        return maxTotal;
    }
}