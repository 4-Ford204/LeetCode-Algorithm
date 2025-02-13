public class Solution {
    public int MinOperations(int[] nums, int k) {
        var heap = new PriorityQueue<int, int>();
        int result = 0;

        foreach (var num in nums)
            if (num < k) heap.Enqueue(num, num);

        while (heap.Count > 1) {
            int first = heap.Dequeue();
            int second = heap.Dequeue();
            int value = first * 2 + second;

            if (first * 2 < k - second) heap.Enqueue(value, value);

            result++;
        }

        return result + heap.Count;
    }
}