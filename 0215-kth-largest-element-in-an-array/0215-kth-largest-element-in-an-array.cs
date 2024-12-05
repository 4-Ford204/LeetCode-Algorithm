public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        return Frequency(nums, k);
    }

    private int Frequency(int[] nums, int k) {
        int min = int.MaxValue;
        int max = int.MinValue;
        int tracking = k;

        foreach (var num in nums) {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        int[] frequency = new int[max - min + 1];
        foreach (var num in nums) frequency[num - min]++;

        for (int i = frequency.Length - 1; i >= 0; i--) {
            tracking -= frequency[i];
            if (tracking <= 0) return i + min;
        }

        return -1;
    }

    private int PriorityQueue(int[] nums, int k) {
        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

        foreach (var num in nums) {
            priorityQueue.Enqueue(num, num);
            if (priorityQueue.Count > k) priorityQueue.Dequeue();
        }

        return priorityQueue.Peek();
    }
}