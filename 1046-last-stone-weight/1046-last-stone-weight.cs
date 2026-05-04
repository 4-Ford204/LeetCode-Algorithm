public class Solution {
    public int LastStoneWeight(int[] stones) {
        var heap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach (var stone in stones) heap.Enqueue(stone, stone);

        while (heap.Count > 1) {
            int stone = heap.Dequeue() - heap.Dequeue();
            if (stone != 0) heap.Enqueue(stone, stone);
        }

        return heap.Count == 0 ? 0 : heap.Peek();
    }
}